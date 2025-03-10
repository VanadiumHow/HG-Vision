using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProgram.Common
{
    /// <summary>
    /// MD5加盐
    /// </summary>
    public sealed class MD5Encrypt
    {
       　/// <summary>
        /// 创建哈希字符串适用于任何 MD5 哈希函数 （在任何平台） 上创建 32 个字符的十六进制格式哈希字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Get32MD5One(string source)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(source));
                System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                string hash = sBuilder.ToString();
                return hash.ToUpper();
            }
        }

        /// <summary>
        /// 获取16位md5加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Get16MD5One(string source)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(source));
                //转换成字符串，并取9到25位
                string sBuilder = BitConverter.ToString(data, 4, 8);
                //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉
                sBuilder = sBuilder.Replace("-", "");
                return sBuilder.ToString().ToUpper();
            }
        }

        //// <summary>
        /// </summary>
        /// <param name="strSource">需要加密的明文</param>
        /// <returns>返回32位加密结果，该结果取32位加密结果的第9位到25位</returns>
        public static string Get32MD5Two(string source)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //获取密文字节数组
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(source));
            //转换成字符串，32位
            string strResult = BitConverter.ToString(bytResult);
            //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉
            strResult = strResult.Replace("-", "");
            return strResult.ToUpper();
        }

        //// <summary>
        /// </summary>
        /// <param name="strSource">需要加密的明文</param>
        /// <returns>返回16位加密结果，该结果取32位加密结果的第9位到25位</returns>
        public static string Get16MD5Two(string source)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //获取密文字节数组
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(source));
            //转换成字符串，并取9到25位
            string strResult = BitConverter.ToString(bytResult, 4, 8);
            //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉
            strResult = strResult.Replace("-", "");
            return strResult.ToUpper();
        }
    }
}
