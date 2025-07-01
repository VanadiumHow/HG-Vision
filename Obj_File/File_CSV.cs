using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using OfficeOpenXml;

namespace Obj.Obj_File
{
    public class File_CSV
    {
        private const string BaseCSVDirectory = @"D:\CSV";

        /// <summary>
        /// 保存CSV文件
        /// </summary>
        public bool SaveToCSV(string strHead, string[] dataRows, string subDirectory)
        {
            if (string.IsNullOrEmpty(subDirectory))
                return false;

            try
            {
                string filePath = GetDailyFilePath(subDirectory);
                EnsureDirectoryExists(filePath);

                if (!File.Exists(filePath))
                    WriteFileHeader(filePath, strHead);

                AppendDataToFile(filePath, dataRows);
                return true;
            }
            catch (Exception ex)
            {
                LogError($"保存CSV失败: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 创建.CSV文件并用Excel打开
        /// </summary>
        /// <exception cref="ArgumentException">数组长度错误</exception>
        public static void GenerateAndOpenCsv(double[][] xyData)
        {
            ValidateXYDataStructure(xyData);
            string tempFile = CreateTempFilePath();
            WriteXYDataToCsv(xyData, tempFile);
            OpenFileWithExcel(tempFile);
        }

        public void SaveGRRData(string item, string time)
        {
            try
            {
                string directoryPath = CreateDailyGRRDirectory();
                string filePath = Path.Combine(directoryPath, $"{time}.csv");
                bool isNewFile = !File.Exists(filePath);

                using (var stream = new FileStream(filePath, isNewFile ? FileMode.Create : FileMode.Append))
                {
                    using (var writer = new StreamWriter(stream, Encoding.Default))
                    {
                        if (isNewFile)
                            writer.WriteLine("时间,夹具号,电芯号,称重,线扫,焊缝轮廓度,焊缝宽度,焊缝直径,焊缝同心度,密封钉轮廓度");

                        writer.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"保存GRR数据失败: {ex.Message}");
            }
        }

        public bool DeleteCSVFile(int retentionDays)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "CSV");
                if (!Directory.Exists(path)) return true;

                var files = Directory.GetFiles(path, "*.csv");
                var deleteThreshold = DateTime.Now.AddDays(-retentionDays).ToString("yyyyMMdd");

                files
                    .Where(file =>
                        Path.GetFileNameWithoutExtension(file).CompareTo(deleteThreshold) < 0)
                    .ToList()
                    .ForEach(File.Delete);

                return true;
            }
            catch (Exception ex)
            {
                LogError($"删除CSV文件失败: {ex.Message}");
                return false;
            }
        }

        #region Helper Methods
        private static string GetDailyFilePath(string subDirectory)
        {
            string directoryPath = Path.Combine(BaseCSVDirectory, subDirectory);
            return Path.Combine(directoryPath, $"{DateTime.Now:yyyyMMdd}.csv");
        }

        private static void EnsureDirectoryExists(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
        }

        private static void WriteFileHeader(string filePath, string header)
        {
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(header);
                }
            }
        }

        private static void AppendDataToFile(string filePath, string[] dataRows)
        {
            using (var fs = new FileStream(filePath, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(string.Join(",", dataRows));
                }
            }
        }

        private static void ValidateXYDataStructure(double[][] xyData)
        {
            if (xyData == null || xyData.Length != 2 || xyData[0].Length != 9 || xyData[1].Length != 9)
                throw new ArgumentException("数据必须为 double[2][9] 数组");
        }

        private static string CreateTempFilePath()
        {
            return Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.csv");
        }

        private static void WriteXYDataToCsv(double[][] xyData, string filePath)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Step,x,y,dx,dy");

            for (int i = 0; i < 9; i++)
            {
                var row = new List<string>
                {
                    (i + 1).ToString(),    // Step
                    xyData[0][i].ToString(), // x
                    xyData[1][i].ToString()  // y
                };

                if (i > 0)
                {
                    row.Add((xyData[0][i] - xyData[0][i - 1]).ToString()); // dx
                    row.Add((xyData[1][i] - xyData[1][i - 1]).ToString()); // dy
                }

                csv.AppendLine(string.Join(",", row));
            }

            File.WriteAllText(filePath, csv.ToString());
        }

        private static void OpenFileWithExcel(string filePath)
        {
            Process.Start(new ProcessStartInfo(filePath)
            {
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private static string CreateDailyGRRDirectory()
        {
            string path = $"CSV//GRR//{DateTime.Now:yyyyMMdd}";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }

        private static void LogError(string message)
        {
            // 实际应用中可替换为日志框架（如NLog, Serilog等）
            Debug.WriteLine($"[Error] {DateTime.Now:HH:mm:ss} - {message}");
        }
        #endregion
        #region Epplus Excel转DataTable工具方法
        /// <summary>
        /// 读取Excel表格到程序，转换成DataTable表格
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static DataTable GetSheetReaderExcel(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            DataTable dt = null;

            using (ExcelPackage package = new ExcelPackage(file))
            {
                //创建工作簿
                ExcelWorkbook workbook = package.Workbook;
                if (workbook != null)
                {
                    if (workbook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet worksheet = workbook.Worksheets.First();
                        dt = worksheetToTable(worksheet);
                    }

                }
            }

            return dt;
        }
        /// <summary>
        /// 读取指定名字的sheet转换成DataTable表格
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<DataTable> GetSheetsReaderExcel(string filePath, List<string> sheetNames)
        {
            FileInfo file = new FileInfo(filePath);
            List<DataTable> dataTableList = null;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorkbook workbook = package.Workbook;
                if (workbook != null && workbook.Worksheets.Count > 0)
                {
                    dataTableList = new List<DataTable>();
                    for (int i = 0; i < sheetNames.Count; i++)
                    {
                        ExcelWorksheet worksheet = workbook.Worksheets[sheetNames[i]];
                        DataTable dt = worksheetToTable(worksheet);
                        dataTableList.Add(dt);
                    }
                }
            }
            return dataTableList;
        }
        private static DataTable worksheetToTable(ExcelWorksheet worksheet)
        {
            if (worksheet == null)
                return null;

            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            DataTable dt = new DataTable(worksheet.Name);
            DataRow dr = null;

            for (int i = 1; i <= rows; i++)
            {
                if (i > 1)
                {
                    dr = dt.Rows.Add();
                }
                for (int j = 1; j <= cols; j++)
                {
                    try
                    {

                        if (i == 1)
                        {
                            dt.Columns.Add(worksheet.Cells[i, j].Value.ToString());
                        }
                        else
                        {
                            dr[j - 1] = worksheet.Cells[i, j].Value.ToString();
                        }
                    }
                    catch
                    {

                        throw;
                    }
                }
            }
            return dt;
        }
        #endregion
    }
}