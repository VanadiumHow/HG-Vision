using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionProgram.Main.ProjectClass.Vision.Global
{
  public static  class GlobalCameraParams
    {
        //图像窗口列表
        public static List<CogRecordsDisplay> cameraVisionControlList = new List<CogRecordsDisplay>();
        //设置权限
        public static List<ToolStripMenuItem> toolStripMenuItem = new List<ToolStripMenuItem>();
    }
}
