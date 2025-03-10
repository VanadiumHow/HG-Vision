using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using VisionProgram.Common;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.User
{
    public class UserConfiguration
    {
        internal UserConfiguration() { }

        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                //配置文件夹
                if (!Directory.Exists(FilePathModel.UserPath))
                    Directory.CreateDirectory(FilePathModel.UserPath);
                //主配置文件ini
                if (!File.Exists(FilePathModel.UserInfoFilePath))
                    File.Create(FilePathModel.UserInfoFilePath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查用户信息配置文件路径出现异常", ex);
            }
        }


        /// <summary>
        /// 解析UserInfo,初始化userInfoDic
        /// </summary>
        public void AnalysisUserInfoConfig(SortedDictionary<string, string> userRoleDic,ref Dictionary<string, UserInfoModel> userInfoDic)
        {
            try
            {
                InitConfigDirctory();

                Dictionary<string, string> dic = SerializeHelper.BinaryDeserialize<Dictionary<string, string>>(FilePathModel.UserInfoFilePath);
                List<UserInfoModel> userList = new List<UserInfoModel>();

                foreach (String s in dic.Keys)
                {
                    userInfoDic.Add(userRoleDic[s], new UserInfoModel(dic[s], s, userRoleDic[s]));
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("解析用户信息配置文件出现异常", ex);
            }
        }

        /// <summary>
        /// 注册或者修改时调用写入二进制文件
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveOrUpdate(Dictionary<string, string> dic)
        {
            SerializeHelper.BinarySerialize<Dictionary<string, string>>(FilePathModel.UserInfoFilePath, dic);
        }

    }
}
