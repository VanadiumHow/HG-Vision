using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
using OMRON.Compolet.CIPCompolet64;
using VisionProgram.Common;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.ProjectClass.PLC
{
    public class PLCOmron : BasePLC
    {
        public NJCompolet NJPLC;
        public PLCOmron(string PLCAddress, int PortNo, IContainer Container,int number = 0,string description = "") :base("Omron", number, description)
        {
            try
            {
                NJPLC = new NJCompolet(Container);
                NJPLC.ConnectionType = OMRON.Compolet.CIPCompolet64.ConnectionType.UCMM;
                NJPLC.LocalPort = PortNo;
                NJPLC.PeerAddress = PLCAddress;
                NJPLC.UseRoutePath = false;
                NJPLC.DontFragment = false;
                NJPLC.ReceiveTimeLimit = ((long)(5000));
            }
            catch (Exception ex)
            {
                LogHelper.Fatal("PLC实例化出现异常", ex);
            }
        }

        public override bool ConnectionState()
        {
             return NJPLC.IsConnected;
        }

        public override bool Connect()
        {
            try
            {
                NJPLC.Active = true;
            }
            catch (Exception ex)
            {
                NJPLC.Active = false;
                LogHelper.Fatal("连接欧姆龙PLC出现异常", ex);
            }
            return NJPLC.IsConnected;
        }

        public override void Dispose()
        {
            NJPLC.Dispose();
        }


        public int Write<T>(int addr, T value, int group)
        {
            throw new NotImplementedException();
        }
        public int Read<T>(int addr, out T value, int group)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public override bool WriteToPlc<T>(string varname, T TagValue)
        {
            try
            {
                NJPLC.WriteVariable(varname, TagValue);
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向欧姆龙PLC写入{varname}信号时出现异常", ex);
                return false;
            }

            if ((object)TagValue == (object)(NJPLC.ReadVariable(varname)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TagName"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public override bool Write<T>(string TagName, T TagValue)
        {
            try
            {
                NJPLC.WriteVariable(TagName, TagValue);
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向欧姆龙PLC写入{TagName}信号时出现异常", ex);
                return false;
            }
            return true;

        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TagName"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public override bool Read<T>(string TagName, out T TagValue)
        {
            TagValue = default(T);
            object obj = null;
            if (TagName != null)
            {
                try
                {
                    obj = NJPLC.ReadVariable(TagName);
                }
                catch (Exception ex)
                {
                    LogHelper.Fatal($"向欧姆龙PLC读取{TagName}信号时出现异常", ex);
                    return false;
                }
            }
            if (obj != null)
            {
                TagValue = (T)obj;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <param name="TagNameList"></param>
        /// <param name="TagValueList"></param>
        /// <returns></returns>
        public override bool ReadMultiTagValue<T>(string[] TagNameList, out T[] TagValueList)
        {
            int Len = TagNameList.Length;
            Hashtable retVals = null;
            TagValueList = new T[Len];
            try
            {
                retVals = NJPLC.ReadVariableMultiple(TagNameList);
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向欧姆龙PLC读取多信号时出现异常", ex);
                return false;
            }

            if (retVals != null)
            {
                for (int i = 0; i < Len; i++)
                {
                    TagValueList[i] = (T)retVals[TagNameList[i]];
                }
                return true;
            }
            else
                return false;
        }

        public int ReadTag<T>(string varname, out T val)
        {
            val = default(T);
            if (varname != null)
            {
                try
                {
                    val = (T)NJPLC.ReadVariable(varname);
                }
                catch 
                {
                    return 0;
                }
            }
            if (val != null)
                return 1;
            else
                return 0;
        }


        public bool ActiveConnection()
        {
            try
            {
                NJPLC.Active = true;
            }
            catch 
            {
                // NJPLC.Active = false;
            }
            return NJPLC.IsConnected;
        }
        

      

        public string GetValueOfVariables(object val)
        {
            string valStr = string.Empty;
            if (val == null)
                return "0";
            if (val.GetType().IsArray)
            {
                Array valArray = val as Array;
                if (valArray.Rank == 1)
                {
                    valStr += "[";
                    foreach (object a in valArray)
                    {
                        valStr += this.GetValueString(a) + ",";
                    }
                    valStr = valStr.TrimEnd(',');
                    valStr += "]";
                }
                else if (valArray.Rank == 2)
                {
                    for (int i = 0; i <= valArray.GetUpperBound(0); i++)
                    {
                        valStr += "[";
                        for (int j = 0; j <= valArray.GetUpperBound(1); j++)
                        {
                            valStr += this.GetValueString(valArray.GetValue(i, j)) + ",";
                        }
                        valStr = valStr.TrimEnd(',');
                        valStr += "]";
                    }
                }
                else if (valArray.Rank == 3)
                {
                    for (int i = 0; i <= valArray.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= valArray.GetUpperBound(1); j++)
                        {
                            valStr += "[";
                            for (int z = 0; z <= valArray.GetUpperBound(2); z++)
                            {
                                valStr += this.GetValueString(valArray.GetValue(i, j, z)) + ",";
                            }
                            valStr = valStr.TrimEnd(',');
                            valStr += "]";
                        }
                    }
                }
            }
            else
            {
                valStr = this.GetValueString(val);
            }
            return valStr;
        }
        private string GetValueString(object val)
        {
            if (val is float || val is double || val is int)
            {
                return string.Format("{0}", val);
            }
            else
            {
                return val.ToString();
            }
        }

    }
}
