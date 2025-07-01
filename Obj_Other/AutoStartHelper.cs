using System;
using System.IO;
using System.Windows.Forms;

namespace Obj.Obj_Other
{
    public static class AutoStartHelper
    {
        //启动文件路径(当前用户)
        private static readonly string StartupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        //创建快捷方式
        public static void CreateShortcut()
        {
            //创建 WshShell 对象
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            //原路径
            string appPath = Application.ExecutablePath;
            //目标路径
            string shortcutTargetPath = Path.Combine(StartupFolderPath, "HG_Vision.lnk");

            //创建快捷方式
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutTargetPath);
            shortcut.TargetPath = appPath; // 设置目标路径
            shortcut.WorkingDirectory = Path.GetDirectoryName(appPath); // 设置工作目录
            shortcut.Description = "钢壳定位视觉软件"; // 设置快捷方式描述
            shortcut.Save();
        }

        // 删除快捷方式
        public static void DeleteShortcut()
        {
            string shortcutPath = Path.Combine(StartupFolderPath, "HG_Vision.lnk");
            if (File.Exists(shortcutPath))
            {
                File.Delete(shortcutPath);
            }
        }

        //检查快捷方式是否存在
        public static bool CheckShortCut()
        {
            string shortcutPath = Path.Combine(StartupFolderPath, "HG_Vision.lnk");
            return File.Exists(shortcutPath);
        }
    }
}
