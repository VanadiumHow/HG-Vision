using Model.ConstantModel;
using Model.SocketModel;
using Model.UserModel;
using Model.VisionModel;
using Obj.Obj_File;
using Obj.Obj_User;
using System;
using System.IO;
using System.Windows;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Socket
{
    /// <summary>
    /// 服务器配置解析类(用于解析配置文件)
    /// </summary>
    public class SeverConfiguration
    {
        public void AnalysisServerInfoConfig(ref RobotClientModel Client)
        {
            try
            {
                Client = XmlHelper.Deserialize<RobotClientModel>(FilePathModel.RobotClientPath);
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisServerInfoConfig方法调用Deserialize方法失败", ex);
            }
        }
        public void AnalysisServerInfoConfig(ref LaserClientModel Client)
        {
            try
            {
                Client = XmlHelper.Deserialize<LaserClientModel>(FilePathModel.LaserClientPath);
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisServerInfoConfig方法调用Deserialize方法失败", ex);
            }
        }
        /// <summary>
        /// 保存参数至.xml文件
        /// </summary>
        public void SaveServerInfoConfig(RobotClientModel Client)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(FilePathModel.RobotClientPath, Client);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveServerInfoConfig方法调用Serialize方法失败", ex);
            }
        }
        public void SaveServerInfoConfig(LaserClientModel Client)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(FilePathModel.LaserClientPath, Client);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveServerInfoConfig方法调用Serialize方法失败", ex);
            }
        }
    }
}