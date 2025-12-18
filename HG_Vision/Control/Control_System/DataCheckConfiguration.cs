using System;
using System.IO;
using System.Windows;
using Model.ConstantModel;
using Obj.Obj_File;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_System
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    public class CheckInfo
    {
        public bool OpenCheckRepeatedCode;//是否开启重码校验     
        public int BatteryCodeLength;//BatteryCodeLength 电芯长度
        public bool OpenBatteryIdent;//是否开启电芯公告代码控制（二维码前缀校验）      
        public string BatteryIdent;//BatteryIdent 前缀

        public bool OpenMes;//是否开启MES校验
        public bool OpenCapacity;//是否开启容量校验      
        public double CapacityMin;//容量上下限
        public double CapacityMax;//容量上下限
        public bool OpenThickness; //是否开启厚度校验 
        public double ThicknessMin;//厚度下限
        public double ThicknessMax; //厚度上限
        public bool OpenDcir;//是否开启DCIR校验           
        public double DCIRMin;// Dcir下限
        public double DCIRMax;//Dcir上限
        public bool OpenAcir;//是否开启ACIR校验            
        public double ACIRMin;//Acir下限
        public double ACIRMax;//Acir上限
        public bool OpenSelfDisCharge;//是否开启自放电校验
        public double SelfDisChargeMin;//自放电下限
        public double SelfDisChargeMax;//自放电上限
        public bool OpenResidual;//是否开启残余量
        public double ResidualMin;//残余量下限
        public double ResidualMax;//残余量上限
        public bool OpenGrade;//是否开启档位校验         
        public string CellGrade;//CellGrade=NULL 默认值      
    }

    public class DataCheckConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(FilePathModel.MESDataCheckPath);

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
                if (!File.Exists(FilePathModel.ConfigPath + "\\DataCheckComm.ini"))
                    File.Create(FilePathModel.ConfigPath + "\\DataCheckComm.ini").Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查数据校验参数配置文件路径出现异常", ex);
            }
        }

        /// <summary>
        /// 解析DataCheck,初始化CheckInfo
        /// </summary>
        public void AnalysisDataCheckCommConfig(ref CheckInfo checkInfo)
        {
            try
            {
                InitConfigDirctory();

                checkInfo.OpenCheckRepeatedCode = bool.Parse(_ini.IniReadValue("ScanSelf", "OpenCheckRepeatedCode"));
                checkInfo.BatteryCodeLength = int.Parse(_ini.IniReadValue("ScanSelf", "BatteryCodeLength"));
                checkInfo.OpenBatteryIdent = bool.Parse(_ini.IniReadValue("ScanSelf", "OpenBatteryIdent"));
                checkInfo.BatteryIdent = _ini.IniReadValue("ScanSelf", "BatteryIdent");

                checkInfo.OpenMes = bool.Parse(_ini.IniReadValue("MES", "OpenMes"));
                checkInfo.OpenCapacity = bool.Parse(_ini.IniReadValue("MES", "OpenCapacity"));
                checkInfo.CapacityMin = double.Parse(_ini.IniReadValue("MES", "CapacityMin"));
                checkInfo.CapacityMax = double.Parse(_ini.IniReadValue("MES", "CapacityMax"));
                checkInfo.OpenThickness = bool.Parse(_ini.IniReadValue("MES", "OpenThickness"));
                checkInfo.ThicknessMin = double.Parse(_ini.IniReadValue("MES", "ThicknessMin"));
                checkInfo.ThicknessMax = double.Parse(_ini.IniReadValue("MES", "ThicknessMax"));
                checkInfo.OpenDcir = bool.Parse(_ini.IniReadValue("MES", "OpenDcir"));
                checkInfo.DCIRMin = double.Parse(_ini.IniReadValue("MES", "DCIRMin"));
                checkInfo.DCIRMax = double.Parse(_ini.IniReadValue("MES", "DCIRMax"));
                checkInfo.OpenAcir = bool.Parse(_ini.IniReadValue("MES", "OpenAcir"));
                checkInfo.ACIRMin = double.Parse(_ini.IniReadValue("MES", "ACIRMin"));
                checkInfo.ACIRMax = double.Parse(_ini.IniReadValue("MES", "ACIRMax"));
                checkInfo.OpenSelfDisCharge = bool.Parse(_ini.IniReadValue("MES", "OpenSelfDisCharge"));
                checkInfo.SelfDisChargeMin = double.Parse(_ini.IniReadValue("MES", "SelfDisChargeMin"));
                checkInfo.SelfDisChargeMax = double.Parse(_ini.IniReadValue("MES", "SelfDisChargeMax"));
                checkInfo.OpenResidual = bool.Parse(_ini.IniReadValue("MES", "OpenResidual"));
                checkInfo.ResidualMin = double.Parse(_ini.IniReadValue("MES", "ResidualMin"));
                checkInfo.ResidualMax = double.Parse(_ini.IniReadValue("MES", "ResidualMax"));
                checkInfo.OpenGrade = bool.Parse(_ini.IniReadValue("MES", "OpenGrade"));
                checkInfo.CellGrade = _ini.IniReadValue("MES", "CellGrade");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析数据校验参数配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析数据校验参数配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }

        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveOneParams(string section, string node, string value)
        {
            try
            {
                _ini.WriteIniKey(section, node, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"{section}段 {node} 节点 写入{value}出现异常：{ex.Message}");
            }
        }

    }
}
