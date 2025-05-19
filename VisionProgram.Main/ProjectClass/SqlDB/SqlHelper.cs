using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using VisionProgram.Models.DModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.ProjectClass.SqlDB
{
    /// <summary>
    /// SqlHelper
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 超时时间
        /// </summary>
        public static int CommandTimeOut = 600;

        #region 是否可以连接数据库
        public static bool IsConnectDB(string connStr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("连接SQLserver数据库失败，原因：" + ex.Message);
                }
            }
        }
        #endregion


        /// <summary>
        /// 增、删、改的通用方法
        /// 执行Sql语句或存储过程，返回受影响的行数
        /// SQL注入 
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            int result = 0;//返回结果
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                //执行脚本的对象cmd
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, trans, parameters);
                try
                {
                    result = cmd.ExecuteNonQuery();//执行T-SQL并返回受影响行数
                    trans.Commit();
                    cmd.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("sql语句执行失败，原因：" + ex.Message);
                }
            }
            return result;
        }

        /// <summary>
        /// 执行sql查询，返回第一行第一列的值
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static object ExecuteScalar(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            object result = null;//返回结果
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //执行脚本的对象cmd
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
                result = cmd.ExecuteScalar();//执行T-SQL并返回第一行第一列的值
                cmd.Parameters.Clear();
                if (result == null || result == DBNull.Value)
                {
                    return null;
                }
                else
                {
                    return result;
                }
            }
        }

        /// <summary>
        /// 执行sql查询,返回SqlDataReader对象
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("创建reader对象发生异常", ex);
            }

        }

        /// <summary>
        /// 执行查询，查询结果填充到DataTable 只针对查询一个表的情况
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cmd.Parameters.Clear();
            }
            return dt;
        }

        /// <summary>
        /// 执行查询，数据填充到DataSet
        /// </summary>
        /// <param name="sql">sql语句或存储过程</param>
        /// <param name="cmdType">执行的脚本类型 1:sql语句  2:存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            DataSet ds = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
                //数据适配器
                //conn 自动打开  断开式连接
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                cmd.Parameters.Clear();
                //自动关闭conn
            }
            return ds;
        }

        /// <summary>
        /// 事务 执行批量sql
        /// </summary>
        /// <param name="listSql"></param>
        /// <returns></returns>
        public static bool ExecuteTrans(string connStr, List<string> listSql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                SqlCommand cmd = BuilderCommand(conn, "", 1, trans);
                try
                {
                    int count = 0;
                    for (int i = 0; i < listSql.Count; i++)
                    {
                        if (listSql[i].Length > 0)
                        {
                            cmd.CommandText = listSql[i];
                            cmd.CommandType = CommandType.Text;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("执行事务出现异常", ex);
                }
            }
        }

        /// <summary>
        /// 事务 批量执行 CommandInfo 包括sql,脚本类型，参数列表
        /// </summary>
        /// <param name="comList"></param>
        /// <returns></returns>
        public static bool ExecuteTrans(string connStr, List<CommandInfo> comList)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                SqlCommand cmd = BuilderCommand(conn, "", 1, trans);
                try
                {
                    int count = 0;
                    for (int i = 0; i < comList.Count; i++)
                    {
                        cmd.CommandText = comList[i].CommandText;

                        if (comList[i].IsProc)
                            cmd.CommandType = CommandType.StoredProcedure;
                        else
                            cmd.CommandType = CommandType.Text;

                        if (comList[i].Paras != null && comList[i].Paras.Length > 0)
                        {
                            cmd.Parameters.Clear();
                            foreach (var p in comList[i].Paras)
                            {
                                cmd.Parameters.Add(p);
                            }
                        }
                        count += cmd.ExecuteNonQuery();

                    }
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("执行事务出现异常", ex);
                }
            }
        }

        //public static T ExecuteSql<T>(string sql, int cmdType, DbParameter[] paras, Func<IDbCommand, T> action)
        //{
        //    using (DbConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();
        //        IDbCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = sql;
        //        if (cmdType==2)
        //            cmd.CommandType = CommandType.StoredProcedure;
        //        return action(cmd);
        //    }
        //}

        public static T ExecuteTrans<T>(string connStr, Func<IDbCommand, T> action)
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                IDbTransaction trans = conn.BeginTransaction();
                IDbCommand cmd = conn.CreateCommand();
                cmd.Transaction = trans;
                return action(cmd);
            }
        }

        /// <summary>
        /// 数据库备份
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteBackup(string connStr, string sql, int cmdType, params SqlParameter[] parameters)
        {
            int result = 0;//返回结果
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //执行脚本的对象cmd
                SqlCommand cmd = BuilderCommand(conn, sql, cmdType, null, parameters);
                try
                {
                    result = cmd.ExecuteNonQuery();//执行T-SQL并返回受影响行数
                    cmd.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    throw new Exception("sql语句执行失败，原因：" + ex.Message);
                }
            }
            return result;
        }


        /// <summary>
        /// 构建SqlCommand
        /// </summary>
        /// <param name="conn">数据库连接对象</param>
        /// <param name="sql">SQL语句或存储过程</param>
        /// <param name="comType">命令字符串的类型</param>
        /// <param name="trans">事务</param>
        /// <param name="paras">参数数组</param>
        /// <returns></returns>
        private static SqlCommand BuilderCommand(SqlConnection conn, string sql, int cmdType, SqlTransaction trans, params SqlParameter[] paras)
        {
            if (conn == null) throw new ArgumentNullException("连接对象不能为空！");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            command.CommandTimeout = CommandTimeOut;
            if (cmdType == 2)
                command.CommandType = CommandType.StoredProcedure;
            if (trans != null)
                command.Transaction = trans;
            if (paras != null && paras.Length > 0)
            {
                command.Parameters.Clear();
                command.Parameters.AddRange(paras);
            }
            return command;
        }


        /// <summary>
        /// 通过传递参数查询对象反射创建sql参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static List<SqlParameter> CreateParameters<T>(T t)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            List<SqlParameter> listParas = properties.Select(p => new SqlParameter("@" + char.ToLower(p.Name[0]) + p.Name.Substring(1), p.GetValue(t) ?? DBNull.Value)).ToList();
            return listParas;
        }

        #region 创建操作日志表

        /// <summary>
        /// 返回创建操作日志表的sql语句。后期可优化成通过实体类动态建表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static void CreateOperationLogDataModelTable(string sqlconn)
        {
            string sqlstr = @"CREATE TABLE [dbo].[OperationLogData](
	                        [num] [bigint] IDENTITY(1,1) NOT NULL,
	                        [loginRoleName] [varchar](10) NOT NULL,
	                        [logType] [varchar](15) NOT NULL,
	                        [modifyField] [varchar](30) NULL,
	                        [oldValue] [varchar](30) NULL,
	                        [newValue] [varchar](30) NULL,
	                        [modifyInfo] [varchar](100) NOT NULL,
	                        [createDatetime] [datetime] NOT NULL,
                         CONSTRAINT [PK_OperationLogData] PRIMARY KEY CLUSTERED 
                        (
	                        [num] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                        ) ON [PRIMARY]";

            SqlHelper.ExecuteNonQuery(sqlconn, sqlstr, 1, null);
        }

        /// <summary>
        /// 判断某表是否数据库中已存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlconn"></param>
        /// <returns></returns>
        public static bool IsExistTable(string tableName, string sqlconn)
        {
            string sqlstr = "IF OBJECT_ID('" + tableName + "','U') IS NULL SELECT 0 ELSE SELECT 1";
            using (SqlConnection conn = new SqlConnection(sqlconn))
            {
                SqlCommand cmd = BuilderCommand(conn, sqlstr, 1, null, null);
                object isExist = cmd.ExecuteScalar();
                if (isExist.ToString() != "1")
                    return false;
                else
                    return true;
            }
        }

        #endregion

        #region 创建操作日志存储过程
        public static void CreateInsertOperationLogDataProc(string sqlconn)
        {
            string sqlstr = @"CREATE PROCEDURE[dbo].[PROC_InsertOperationLogData] 
                @loginRoleName varchar(10) ,@logType varchar(15) ,@modifyField varchar(30) ,@oldValue varchar(30) ,	
	            @newValue varchar(30) ,	@modifyInfo varchar(100) ,@createDatetime datetime
                AS BEGIN
                INSERT INTO OperationLogData([loginRoleName] , [logType], [modifyField] , [oldValue], [newValue], [modifyInfo], [createDatetime])
                VALUES(@loginRoleName , @logType , @modifyField , @oldValue, @newValue, @modifyInfo, @createDatetime)
                END";

            SqlHelper.ExecuteNonQuery(sqlconn, sqlstr, 1, null);
        }


        public static void CreateGetOperationLogDataByPageProc(string sqlconn)
        {
            string sqlstr = @"CREATE PROCEDURE [dbo].[PROC_GetOperationLogDataByPage]
	            @pageIndex int, -- 当前第几页
	            @pageSize int,  -- 每页包含的记录数
	            @startTime datetime ,
	            @endTime datetime,
	            @logType varchar(15)
                AS
                BEGIN

                SELECT COUNT(1) FROM  OperationLogData where
	            createDatetime BETWEEN @startTime AND @endTime 
	            and logType = CASE @logType WHEN 'ALL' THEN logType ELSE @logType END

	            SELECT [logType] AS 日志类型  
                  ,ISNULL([modifyField], '/') AS 属性
	              , ISNULL([oldValue], '/') AS 旧值
                  ,ISNULL([newValue], '/') AS 新值
	              ,[modifyInfo] AS 详情
                  ,[loginRoleName] AS 角色
	              ,[createDatetime] AS 创建时间
	            FROM OperationLogData
	            WHERE createDatetime BETWEEN @startTime AND @endTime 
	            and logType = CASE @logType WHEN 'ALL' THEN logType ELSE @logType END
	            ORDER BY createDatetime desc
	            OFFSET(@pageSize *(@pageIndex - 1)) ROW FETCH NEXT @pageSize ROW ONLY
                END";

            SqlHelper.ExecuteNonQuery(sqlconn, sqlstr, 1, null);
        }


        /// <summary>
        /// 判断某存储过程是否数据库中已存在
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="sqlconn"></param>
        /// <returns></returns>
        public static bool IsExistProc(string procName, string sqlconn)
        {
            string sqlstr = $"SELECT COUNT(*) FROM [sys].[objects] where [type_desc] = 'SQL_STORED_PROCEDURE' AND [name] = '{procName}';";
            using (SqlConnection conn = new SqlConnection(sqlconn))
            {
                SqlCommand cmd = BuilderCommand(conn, sqlstr, 1, null, null);
                object isExist = cmd.ExecuteScalar();
                return (int)isExist > 0;
            }
        }

        #endregion
    }
}
