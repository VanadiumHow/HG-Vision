using Model.ConstantModel;
using Model.SocketModel;
using Obj.Obj_File;
using System;
using System.IO;
using System.Windows;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Socket
{
    public class ClientConfiguration
    {
        public void AnalysisLaserInfoConfig(ref LaserServerModel laserServer)
        {
            try
            {
                laserServer = XmlHelper.Deserialize<LaserServerModel>(FilePathModel.LaserServerPath);
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisLaserInfoConfig方法调用Deserialize方法失败", ex);
            }
        }

        public void AnalysisLaserInfoConfig(ref PLCServerModel pLCServer)
        {
            try
            {
                pLCServer = XmlHelper.Deserialize<PLCServerModel>(FilePathModel.PLCServerPath);
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisLaserInfoConfig方法调用Deserialize方法失败", ex);
            }
        }
        /// <summary>
        /// 保存参数至.xml文件
        /// </summary>
        public void SaveLaserInfoConfig(LaserServerModel laserServer)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(FilePathModel.LaserServerPath, laserServer);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveLaserInfoConfig方法调用Serialize方法失败", ex);
            }
        }
    }
}
