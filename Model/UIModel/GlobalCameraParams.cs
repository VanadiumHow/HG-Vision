using Cognex.VisionPro;
using System.Collections.Generic;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace Model.UIModel
{
    public static class GlobalCameraParams
    {
        //图像窗口列表
        public static List<CogRecordsDisplay> cameraVisionControlList = new List<CogRecordsDisplay>();
        //设置权限
        public static List<ToolStripMenuItem> toolStripMenuItem = new List<ToolStripMenuItem>();
    }
}
