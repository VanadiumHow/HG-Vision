using System;
/****************************************************************

*****************************************************************/
namespace Model.DataModel
{
    /// <summary>
    /// 操作日志类
    /// </summary>
    public class OperationLogDataModel
    {
        private int Num { get; set; }
        public string LoginRoleName { get; set; }
        public string LogType { get; set; }
        public string ModifyField { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ModifyInfo { get; set; }
        public DateTime CreateDatetime { get; set; }


        public OperationLogDataModel()
        {
        }

        public OperationLogDataModel(string LoginRoleName, string logType, string modifyField, string oldValue, string newValue, string modifyInfo)
        {
            this.LoginRoleName = LoginRoleName;
            this.LogType = logType;
            this.ModifyField = modifyField;
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.ModifyInfo = modifyInfo;
            this.CreateDatetime = DateTime.Now;
        }

        public string GetStr()
        {
            return $"角色：{LoginRoleName}。操作详情：{ModifyInfo}。";
        }
    }

}
