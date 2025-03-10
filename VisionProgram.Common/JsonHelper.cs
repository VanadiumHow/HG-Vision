using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Common
{
    /// <summary>
    /// JSON辅助类
    /// </summary>
    public sealed class JsonHelper
    {

        /// <summary>
        /// 将序列化的json字符串内容写入Json文件，并且保存
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="jsonConents">Json内容</param>
        public static void WriteJsonToFile(string path, string jsonConents)
        {
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            //{

            //}
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(jsonConents);
            }
        }

        public static void WriteObjToFile(string path, object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            WriteJsonToFile(path, json);
        }


        /// <summary>
        /// 获取到本地的Json文件并且解析返回对应的实体对象
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        public static T GetObjByJson<T>(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    json = sr.ReadToEnd().ToString();
                    if (!string.IsNullOrEmpty(json))
                    {
                        try
                        {
                            return JsonConvert.DeserializeObject<T>(json);
                        }
                        catch 
                        {
                            return default(T);
                        }
                    }
                }
            }
            return default(T);
        }


        /// <summary>
        /// 获取到本地的Json文件并且解析返回对应的实体对象集合
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        public static List<T> GetArrayByJson<T>(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    json = sr.ReadToEnd().ToString();
                    if (!string.IsNullOrEmpty(json))
                    {
                        try
                        {
                            List<T> result = JsonConvert.DeserializeObject<List<T>>(json);
                            return result;
                        }
                        catch 
                        {
                            return default(List<T>);
                        }
                    }
                }
            }
            return default(List<T>);
        }


    }
}
