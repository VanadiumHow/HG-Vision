using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Common
{
    public class EPPlusHelper
    {
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
        public static List<DataTable> GetSheetsReaderExcel(string filePath,List<string> sheetNames)
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
    }
}
