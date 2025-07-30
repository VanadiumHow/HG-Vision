using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Obj.Obj_File;
using Model.ConstantModel;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_PLC
{
    public class PLCConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(FilePathModel.PlcCommPath);

        internal PLCConfiguration() { }

        /// <summary>
        /// PLC信息结构体
        /// </summary>
        public struct PLCInfo
        {
            public string Type;//plc类型
            public string IP;//plc ip地址
            public string Port;//plc 端口号
            public string Description;//plc描述
            public string SA1;//sa1
        }

        private List<string> plcSignalExcelSheetNameList = new List<string>();

        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                //配置文件夹
                if (!Directory.Exists(FilePathModel.ConfigPath))
                    Directory.CreateDirectory(FilePathModel.ConfigPath);
                //主配置文件ini
                if (!File.Exists(FilePathModel.PlcCommPath))
                    File.Create(FilePathModel.PlcCommPath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查PLC配置文件路径出现异常", ex);
            }
        }

        /// <summary>
        /// 解析PlcComm.ini
        /// </summary>
        public void AnalysisPlcCommConfig(ref List<PLCInfo> L_PlcInfo, ref List<List<PLCSignalInfo>> L_PLCSignalInfoList)
        {
            try
            {
                L_PlcInfo.Clear();
                InitConfigDirctory();
                List<string> L_AllSection = _ini.IniReadAllSection();
                //解析值
                plcSignalExcelSheetNameList.Clear();

                for (int i = 0; i < L_AllSection.Count; i++)
                {
                    PLCInfo plcinfo = new PLCInfo();
                    string plcSection = "PLC" + i.ToString();
                    string type = _ini.IniReadValue(plcSection, "Type");
                    string ip = _ini.IniReadValue(plcSection, "Ip");
                    string port = _ini.IniReadValue(plcSection, "Port");
                    string description = _ini.IniReadValue_UTF8(plcSection, "Description");
                    string sa1 = _ini.IniReadValue_UTF8(plcSection, "SA1");
                    plcinfo.Type = type;
                    plcinfo.Port = port;
                    plcinfo.Description = description;
                    plcinfo.SA1 = sa1;
                    if (plcinfo.Type == "Twincat")
                    {
                        plcinfo.IP = ip + ".1.1";
                    }
                    else if (plcinfo.Type == "Omron")
                    {
                        plcinfo.IP = ip;
                    }
                    //遍历完插入值
                    L_PlcInfo.Add(plcinfo);

                    plcSignalExcelSheetNameList.Add($"PLC{i + 1}");
                }

                //解析信号表EXECL
                // LoadTestSignalExecl(ref L_PLCSignalInfoList, FilePathModel.PlcSignalPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析PLC配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析PLC配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }


        /// <summary>
        /// 加载传递过来的测试信号信息
        /// </summary>
        /// <param name="index">下标</param>
        /// <param name="values">测试信号信息</param>
        public void LoadTestSignalExecl(ref List<List<PLCSignalInfo>> L_PLCSignalInfoList, string excelPath)
        {
            List<List<PLCSignalInfo>> LObjectList = new List<List<PLCSignalInfo>>();
            List<DataTable> dtList = File_CSV.ReadSheetsByName(excelPath, plcSignalExcelSheetNameList);
            for (int i = 0; i < dtList.Count; i++)
            {
                LObjectList.Add(new List<PLCSignalInfo>());
                if (dtList[i] != null)
                {
                    for (int k = 0; k < dtList[i].Rows.Count; k++)
                    {
                        PLCSignalInfo info = new PLCSignalInfo();
                        info.Num = Convert.ToInt32(dtList[i].Rows[k]["序号"].ToString());
                        info.Name = dtList[i].Rows[k]["变量名"].ToString();
                        info.Type = dtList[i].Rows[k]["类型"].ToString();
                        info.Msg = dtList[i].Rows[k]["备注"].ToString();
                        LObjectList[i].Add(info);
                    }
                }
            }
            L_PLCSignalInfoList = LObjectList;
        }
    }
    /// <summary>
    /// PLC信号变量信息
    /// </summary>
    public struct PLCSignalInfo
    {
        public int Num; //序号
        public string Name;//变量名
        public string Type;//类型
        public string Msg;//备注信息
    }
    /// <summary>
    /// 寄存器读取数据后处理类
    /// </summary>
    internal static class RegisterDataProcessing
    {
        /// <summary>
        /// 两两字节交换
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static byte[] ReverseBytes(byte[] input, int index, int count)
        {
            // 参数校验
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (index < 0)
            {
                LogHelper.Error("index必须是非负的");
                return input;
            }
            if (count < 0 || count % 2 != 0)
            {
                LogHelper.Error("index+count超出数组边界");
                return input;
            }

            if (index + count > input.Length)
            {
                LogHelper.Error("index+count超出数组边界");
                return input;
            }
            // 创建输出数组并复制数据
            byte[] output = new byte[count];
            Array.Copy(input, index, output, 0, count);

            // 两两交换字节
            for (int i = 0; i < count; i += 2)
            {
                // 交换相邻字节
                byte temp = output[i];
                output[i] = output[i + 1];
                output[i + 1] = temp;
            }

            return output;
        }
        /// <summary>
        /// 移出字符串中的零字节
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <returns></returns>
        internal static byte[] Remove_zero(byte[] input)
        {
            List<byte> temp = new List<byte>();
            foreach (var element in input)
            {
                if (element != 0)
                {
                    temp.Add(element);
                }
            }
            byte[] output = temp.ToArray();
            return output;
        }
    }
}
