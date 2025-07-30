using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using OfficeOpenXml;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_File
{
    public class File_CSV
    {
        private const string BaseCSVDirectory = @"D:\CSV";

        // ======================= CSV 操作 ======================= //
        /// <summary>
        /// 追加数据到CSV文件（原SaveToCSV）
        /// </summary>
        /// <param name="header">CSV表头</param>
        /// <param name="rows">数据行集合</param>
        /// <param name="subDirectory">子目录路径</param>
        public bool AppendToCsv(string header, IEnumerable<string> rows, string subDirectory)
        {
            if (string.IsNullOrEmpty(subDirectory)) return false;

            try
            {
                string filePath = GetDailyFilePath(subDirectory);
                EnsureDirectoryExists(filePath);

                bool isNewFile = !File.Exists(filePath);
                // 使用传统 using 块（C# 7.3 兼容）
                using (var writer = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    if (isNewFile) writer.WriteLine(header);
                    foreach (var row in rows) writer.WriteLine(row);
                }
                return true;
            }
            catch (Exception ex)
            {
                LogError($"CSV保存失败: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 生成并打开XY数据CSV（原GenerateAndOpenCsv）
        /// </summary>
        /// <param name="xyData">二维数组[2][9]</param>
        public static void ExportAndOpenXYData(double[][] xyData)
        {
            ValidateXYDataStructure(xyData);
            string tempFile = CreateTempFilePath();

            var csv = new StringBuilder();
            csv.AppendLine("Step,x,y,dx,dy");
            for (int i = 0; i < 9; i++)
            {
                var line = new List<string> { (i + 1).ToString(), xyData[0][i].ToString("F4"), xyData[1][i].ToString("F4") };
                if (i > 0)
                {
                    line.Add((xyData[0][i] - xyData[0][i - 1]).ToString("F4")); // dx
                    line.Add((xyData[1][i] - xyData[1][i - 1]).ToString("F4")); // dy
                }
                csv.AppendLine(string.Join(",", line));
            }

            File.WriteAllText(tempFile, csv.ToString());
            OpenFileWithExcel(tempFile);
        }

        /// <summary>
        /// 追加GRR数据（原SaveGRRData）
        /// </summary>
        /// <param name="csvLine">完整CSV行数据</param>
        /// <param name="timePrefix">文件名时间前缀</param>
        public void AppendGRRData(string csvLine, string timePrefix)
        {
            try
            {
                string dirPath = CreateDailyGRRDirectory();
                string filePath = Path.Combine(dirPath, $"{timePrefix}.csv");

                bool writeHeader = !File.Exists(filePath);
                using (var writer = new StreamWriter(filePath, true, Encoding.Default))
                {
                    if (writeHeader)
                        writer.WriteLine("时间,夹具号,电芯号,称重,线扫,焊缝轮廓度,焊缝宽度,焊缝直径,焊缝同心度,密封钉轮廓度");
                    writer.WriteLine(csvLine);
                }
            }
            catch (Exception ex)
            {
                LogError($"GRR数据保存失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 清理过期CSV文件（原DeleteCSVFile）
        /// </summary>
        /// <param name="retentionDays">保留天数</param>
        public bool CleanupExpiredFiles(int retentionDays)
        {
            try
            {
                var csvDir = BaseCSVDirectory;
                if (!Directory.Exists(csvDir)) return true;

                var cutoff = DateTime.Now.AddDays(-retentionDays).ToString("yyyyMMdd");
                foreach (var file in Directory.GetFiles(csvDir, "*.csv"))
                {
                    if (Path.GetFileNameWithoutExtension(file).CompareTo(cutoff) < 0)
                        File.Delete(file);
                }
                return true;
            }
            catch (Exception ex)
            {
                LogError($"文件清理失败: {ex.Message}");
                return false;
            }
        }

        // ===================== Excel 操作 ====================== //
        /// <summary>
        /// 读取Excel首工作表（原GetSheetReaderExcel）
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        public static DataTable ReadFirstSheet(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                return package.Workbook.Worksheets.Count > 0
                    ? ConvertWorksheetToTable(package.Workbook.Worksheets[0])
                    : null;
            }
        }

        /// <summary>
        /// 读取指定名称的工作表（原GetSheetsReaderExcel）
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetNames">工作表名称集合</param>
        public static List<DataTable> ReadSheetsByName(string filePath, IEnumerable<string> sheetNames)
        {
            var result = new List<DataTable>();
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                foreach (var name in sheetNames)
                {
                    var sheet = package.Workbook.Worksheets[name];
                    if (sheet != null)
                        result.Add(ConvertWorksheetToTable(sheet));
                }
            }
            return result;
        }

        // ===================== 辅助方法 ====================== //
        #region Helper Methods
        private static string GetDailyFilePath(string subDirectory)
        {
            return Path.Combine(BaseCSVDirectory, subDirectory, $"{DateTime.Now:yyyyMMdd}.csv");
        }

        private static void EnsureDirectoryExists(string filePath)
        {
            string dir = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        }

        private static void ValidateXYDataStructure(double[][] xyData)
        {
            if (xyData == null || xyData.Length != 2 || xyData[0].Length != 9 || xyData[1].Length != 9)
                throw new ArgumentException("需要 double[2][9] 格式数据");
        }

        private static string CreateTempFilePath()
        {
            return Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.csv");
        }

        private static void OpenFileWithExcel(string filePath)
        {
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private static string CreateDailyGRRDirectory()
        {
            string path = Path.Combine("CSV", "GRR", DateTime.Now.ToString("yyyyMMdd"));
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            return path;
        }

        private static DataTable ConvertWorksheetToTable(ExcelWorksheet worksheet)
        {
            if (worksheet?.Dimension == null) return null;

            var table = new DataTable(worksheet.Name);
            int cols = worksheet.Dimension.Columns;

            // 添加列名（处理空值）
            for (int col = 1; col <= cols; col++)
            {
                string colName = worksheet.Cells[1, col].Text;
                table.Columns.Add(string.IsNullOrEmpty(colName) ? $"Column{col}" : colName);
            }

            // 填充数据（跳过空行）
            for (int row = 2; row <= worksheet.Dimension.Rows; row++)
            {
                var dataRow = table.NewRow();
                bool hasValue = false;
                for (int col = 1; col <= cols; col++)
                {
                    var cell = worksheet.Cells[row, col];
                    dataRow[col - 1] = cell.Text;
                    hasValue |= !string.IsNullOrEmpty(cell.Text);
                }
                if (hasValue) table.Rows.Add(dataRow);
            }
            return table;
        }

        private static void LogError(string message)
        {
            Debug.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }
        #endregion
    }
}