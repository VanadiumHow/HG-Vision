using System;
using System.Collections.Generic;
using Obj.Obj_File;
using Obj.Obj_Sql;
using HG_Vision.Contol.Control_Sql;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/

namespace HG_Vision.Manager.Manager_Sql
{
    public class SqlInfoManager
    {
        /// <summary>
        /// 数据库配置类
        /// </summary>
        private SqlInfoConfiguration _sqlInfoConfiguration = new SqlInfoConfiguration();

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static List<string> L_sqlConnection;
        public static List<string> L_sqlDBName;

        /// <summary>
        /// 数据库数量
        /// </summary>
        public int SqlNum
        {
            get { return 0; }
        }

        internal SqlInfoManager() { }

        /// <summary>
        /// 初始化sql信息对象
        /// </summary>
        public void Initial()
        {
            L_sqlConnection = new List<string>();
            L_sqlDBName = new List<string>();

            int sqlNum = 0;
            _sqlInfoConfiguration.AnalysisSqlInfoConfig(out sqlNum);
            for (int i = 0; i < sqlNum; i++)
            {
                L_sqlConnection.Add(GetConnStr(_sqlInfoConfiguration.A_SqlInfo[i]));
                L_sqlDBName.Add(_sqlInfoConfiguration.A_SqlInfo[i].Database);
            }

            //通过数据库有无来决定操作日志存储位置
            if (sqlNum > 0)
            {
                Project.Instance.GlobalManagerInstance.GlobalParamModel.saveOperationLogsByDB = true;
            }
        }

        /// <summary>
        /// 拼接SQL连接字符串
        /// </summary>
        /// <param name="sqlInfo"></param>
        /// <returns></returns>
        private string GetConnStr(SqlInfoConfiguration.SqlInfo sqlInfo)
        {
            return string.Format("server = {0};database={1};uid={2};pwd={3};Integrated Security = false; MultipleActiveResultSets=true",
                                         sqlInfo.ServerName, sqlInfo.Database, sqlInfo.Uid, sqlInfo.Pwd);
        }

        public List<bool> ConnectSql()
        {
            List<bool> sqlConnectStates = new List<bool>();
            for (int i = 0; i < SqlNum; i++)
            {
                try
                {
                    sqlConnectStates.Add(SqlHelper.IsConnectDB(L_sqlConnection[i]));
                }
                catch (Exception ex)
                {
                    sqlConnectStates.Add(false);
                    LogHelper.Error($"连接{L_sqlDBName[i]}数据库失败", ex);
                }

            }
            return sqlConnectStates;
        }


        #region
        public void CreateOperationLogTable()
        {
            if (!SqlHelper.IsExistTable("OperationLogData", L_sqlConnection[0]))
                SqlHelper.CreateOperationLogDataModelTable(L_sqlConnection[0]);
        }


        public void CreateOperationLogProc()
        {
            if (!SqlHelper.IsExistProc("PROC_InsertOperationLogData", L_sqlConnection[0]))
                SqlHelper.CreateInsertOperationLogDataProc(L_sqlConnection[0]);
            if (!SqlHelper.IsExistProc("PROC_GetOperationLogDataByPage", L_sqlConnection[0]))
                SqlHelper.CreateGetOperationLogDataByPageProc(L_sqlConnection[0]);
        }
        #endregion
    }
}
