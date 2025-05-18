using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
namespace VisionProgram.ProjectClass.Excel
{
    public static class CsvExcelHelper
    {
        public static void GenerateAndOpenCsv(double[][] xyData)
        {
            if (xyData == null || xyData.Length != 2 || xyData[0].Length != 9 || xyData[1].Length != 9)
                throw new ArgumentException("数据必须为 double[2][9] 数组");

            var tempFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".csv");

            // 生成CSV内容
            var csvContent = new StringBuilder();
            csvContent.AppendLine("序号,x,y,dx,dy"); // 标题行

            // 填充数据
            for (int i = 0; i < 9; i++)
            {
                var row = new string[5];
                row[0] = (i + 1).ToString();       // 序号列
                row[1] = xyData[0][i].ToString();   // x值
                row[2] = xyData[1][i].ToString();   // y值

                // 计算差值（从第二行开始）
                if (i > 0)
                {
                    row[3] = (xyData[0][i] - xyData[0][i - 1]).ToString(); // dx
                    row[4] = (xyData[1][i] - xyData[1][i - 1]).ToString(); // dy
                }

                csvContent.AppendLine(string.Join(",", row));
            }

            File.WriteAllText(tempFile, csvContent.ToString());

            // 用Excel打开并自动转换为表格格式
            Process.Start(new ProcessStartInfo(tempFile)
            {
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}