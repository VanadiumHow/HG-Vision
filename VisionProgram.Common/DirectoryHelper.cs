using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Common
{
    /// <summary>
    /// <summary>
    /// 文件夹辅助类
    /// </summary>
    public sealed class DirectoryHelper
    {
        #region Directory Operating
        // 清空文件夹
        public static void EmptyDirectory(string _path)
        {
            if ((null == _path) || !Directory.Exists(_path))
            {
                return;
            }

            foreach (string dirname in Directory.GetDirectories(_path))
            {
                Directory.Delete(dirname, true);
            }
            foreach (string filename in Directory.GetFiles(_path))
            {
                File.Delete(filename);
            }
        }

        // 复制文件夹
        public static void CopyDirectories(string srcDir, string destDir)
        {
            if ((null == destDir) || !Directory.Exists(srcDir))
            {
                return;
            }
            if (!Directory.Exists(destDir))
            {
                DirectoryInfo di = Directory.CreateDirectory(destDir);
                if (!di.Exists)
                {
                    return;
                }
            }
            foreach (string item in Directory.GetDirectories(srcDir))
            {
                string dirName = item.Substring(item.LastIndexOf("\\") + 1);
                CopyDirectories(srcDir + "\\" + dirName, destDir + "\\" + dirName);
            }
            foreach (string filename in Directory.GetFiles(srcDir))
            {
                string fn = filename.Substring(filename.LastIndexOf("\\") + 1);
                File.Copy(srcDir + "\\" + fn, destDir + "\\" + fn, true);
            }
        }
        #endregion
        /// <summary>
        /// Take a filename (generally a relative path) and determine the full path to the file to
        /// use.  First the directory containing the current .vpp file is checked for the given filename,
        /// then the directory containing this code's assembly is checked.
        /// </summary>
        public static string ResolveAssociatedFilename(string vppfname, string fname)
        {
            // check for the given file in the same directory as the developer vpp file path
            return System.IO.Path.GetDirectoryName(vppfname) + "\\" + fname;
        }


    }
}
