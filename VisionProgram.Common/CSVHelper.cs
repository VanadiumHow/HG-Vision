using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace VisionProgram.Common
{
    public class File_CSV
    {
        public File_CSV()
        {
        }

        public bool SaveToCSV(string strHead, string[] strData, string strFile)
        {
            try
            {
                if (strFile == "") return false;
                string strPath = System.IO.Directory.GetCurrentDirectory() + "\\CSV\\" + strFile + "\\";
                string strFilePath = strPath + System.DateTime.Now.ToString("yyyyMMdd") + ".csv";
                if (!Directory.Exists(strPath))//如果路径不存在
                {
                    Directory.CreateDirectory(strPath);//创建一个路径的文件夹
                }
                if (!System.IO.File.Exists(strFilePath))
                {
                    FileStream fs1 = new FileStream(strFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    StreamWriter sw1 = new StreamWriter(fs1, System.Text.Encoding.UTF8);
                    sw1.WriteLine(strHead);
                    sw1.Close();
                    fs1.Close();
                }
                FileStream fs = new FileStream(strFilePath, System.IO.FileMode.Append, System.IO.FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                string data = "";
                for (int i = 0; i < strData.Length; i++)
                {
                    data += strData[i];
                    if (i < strData.Length - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
                sw.Close();
                fs.Close();
                GC.Collect();
            }
            catch
            {
                return false;
            }
            return true;
        }

      

        public void SaveGRRData(string item, string time)
        {
            try
            {
                //bool status = false;
                //status =connectState(@"\\IP",@"账号","密码");
                DirectoryInfo di = new DirectoryInfo($"CSV//GRR//{DateTime.Now.ToString("yyyyMMdd")}");
                if (!di.Exists)
                    di.Create();
                using (FileStream fs = new FileStream($"CSV//GRR//{DateTime.Now.ToString("yyyyMMdd")}//{time}.csv", FileMode.OpenOrCreate))
                {
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                    string str_title = sr.ReadLine();
                    if (str_title != null && str_title.Contains("时间"))
                    {

                    }
                    else
                    {
                        str_title = "时间,夹具号,电芯号,称重,线扫,焊缝轮廓度,焊缝宽度,焊缝直径,焊缝同心度，密封钉轮廓度";
                        sw.WriteLine(str_title.Substring(0, str_title.Length - 1));
                        sw.Flush();
                    }
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    //sw.WriteLine(str_data);
                    sw.WriteLine(item);
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                    sr.Close();
                    sr.Dispose();
                }

            }
            catch (Exception ex)
            {
            }
        }
      

        public bool DeleteCSVFile(int nDay)//删除超过保存天数的CSV文件
        {
            try
            {
                string strDate = System.DateTime.Now.ToString("yyyyMMdd");
                string path = System.IO.Directory.GetCurrentDirectory() + "\\CSV";
                DirectoryInfo folder = new DirectoryInfo(path);
                foreach (FileInfo file in folder.GetFiles("*.csv"))
                {
                    if (Convert.ToInt32(strDate) - Convert.ToInt32(file.Name.Split('.')[0]) > nDay)
                    {
                        File.Delete(file.FullName);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
