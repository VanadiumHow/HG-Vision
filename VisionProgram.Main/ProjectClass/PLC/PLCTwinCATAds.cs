#define  AMS                                   //采用AmsNet方式连接beckhoff,若未定义采用一般的字符连接

using System;
using System.Runtime.InteropServices;
using TwinCAT.Ads;
using System.IO;
using VisionProgram.Common;
using VisionProgram.Models.VModels;


/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.ProjectClass.PLC
{

    /// <summary>
    /// 地址方式访问PLC类
    /// </summary>
    public class PLCTwinCATAds : BasePLC
    {
        private TcAdsClient adsClient;            //客服端连接对象，通讯协议
        private AdsStream adsStream;

        BinaryReader br;
        BinaryWriter bw;

#if AMS
        private AmsNetId amsNetId;                // AMS网络ID
        //private AmsPort amsPort;                  //AMS网络端口
#else
        private string ip;                        //ip+".1.1"
        private int port;                         //连接端口
#endif

        #region
        /// <summary>
        /// 两个参数 构造函数
        /// </summary>
        /// <param name="ex_port">连接端口</param>
        public PLCTwinCATAds(string ex_ip, int ex_port, int number = 0, string description = "") : base("Twincat", number, description)
        {
            adsClient = new TcAdsClient();
#if AMS
            amsNetId = new AmsNetId(ex_ip);
            //amsPort = AmsPort.Tc2_Plc1;        //枚举指定端口801
#else

            port = ex_port;
            ip = ex_ip;
#endif
        }
        #endregion

        public override bool ConnectionState()
        {
            return adsClient.IsConnected;
        }

        /// <summary>
        /// 客户端连接beckoff_ADS PLC
        /// </summary>
        /// <returns>返回连接状态</returns>
        public override bool Connect()
        {
            try
            {
                if (adsClient == null)
                {
                    adsClient = new TcAdsClient();
                }
                if (adsStream == null)
                {
                    adsStream = new AdsStream(8);
                }
                if (!adsClient.IsConnected)
                {
                    try
                    {
#if AMS
                        //adsClient.Connect(amsNetId, amsPort);
                        adsClient.Connect(amsNetId, 851);//使用851
#else
                        adsClient.Connect(ip, port);
#endif
                    }
                    catch (System.Exception ex)
                    {
                        NoticeHelper.OutputMessageSend($"连接倍福PLC出现异常：{ex.Message}", OutputLevelModel.ERROR);
                        LogHelper.Fatal("连接倍福PLC出现异常", ex);
                    }
                }
                try
                {
                    if (adsClient.RouterState == AmsRouterState.Start)
                    {
                        return adsClient.IsConnected;
                    }
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                NoticeHelper.OutputMessageSend($"连接倍福PLC出现异常：{ex.Message}", OutputLevelModel.ERROR);
                return false;
            }
        }

        public override void Dispose()
        {
            if (adsStream != null)
            {
                adsStream.Close();
                adsStream.Dispose();
            }
            if (adsClient != null)
            {
                adsClient.Dispose();
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]//分布结构体内内存地址的位置
        public class ComplexStruct
        {
            [MarshalAs(UnmanagedType.ByValArray)]
            public int[] RCordinationArr;
        }

        public void Initialize()
        {
            Connect();
        }

        #region 写
        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public override bool WriteToPlc<T>(string id, T val)
        {
            try
            {
                if (!adsClient.IsConnected)
                {
                    Connect();
                }
                if (adsClient.IsConnected)
                {
                    adsClient.WriteAny(int.Parse(id), val);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入信号{id.ToString()}时出现异常", ex);
                return false;
            }
        }

        public bool WriteToPlc_short(int id, short value)
        {
            try
            {
                adsClient.WriteAny(id, short.Parse(value.ToString()));
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入信号{id.ToString()}时出现异常", ex);
                return false;
            }
            return true;
        }

        public bool WriteToPlc_int(int id, int value)
        {
            try
            {
                adsClient.WriteAny(id, Int16.Parse(value.ToString()));
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入信号{id.ToString()}时出现异常", ex);
                return false;
            }
            return true;
        }

        public bool WriteToPlc_bool(int id, bool value)
        {
            try
            {
                adsClient.WriteAny(id, bool.Parse(value.ToString()));
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入信号{id.ToString()}时出现异常", ex);
                return false;
            }
            return true;
        }

        public bool WriteToPlc_String(int id, string value)
        {
            try
            {
                adsClient.WriteAny(id, value, new int[] { value.Length + 1 });
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入信号{id.ToString()}时出现异常", ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public override bool Write<T>(string varname, T data)
        {
            try
            {
                if (!adsClient.IsConnected)
                {
                    Connect();
                }
                if (adsClient.IsConnected)
                {
                    int hander_write = adsClient.CreateVariableHandle(varname);
                    if (data.GetType() == typeof(string))
                    {
                        adsClient.WriteAny(hander_write, data.ToString(), new int[] { data.ToString().Length + 1 });
                        return true;
                    }
                    else
                    {
                        adsClient.WriteAny(hander_write, data);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入{varname}信号时出现异常", ex);
                return false;
            }
        }
        public bool CCDWritePLC<T>(int id, T data)
        {
            try
            {
                adsClient.WriteAny(id, data);
                return true;
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"CCDReadPLC读取出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"CCDReadPLC读取出现异常", ex);
                return false;
            }
            finally
            {

            }
        }


        public bool Write(string varname, object data, string dataType, int length)
        {
            try
            {
                int hander_write = adsClient.CreateVariableHandle(varname);
                switch (dataType)
                {
                    case "string":
                        adsClient.WriteAny(hander_write, data.ToString(), new int[] { length });
                        return true;
                    case "bool":
                        adsClient.WriteAny(hander_write, Boolean.Parse(data.ToString()));
                        return true;
                    case "int":
                        adsClient.WriteAny(hander_write, Int16.Parse(data.ToString()));
                        return true;
                    case "float":
                        adsClient.WriteAny(hander_write, Single.Parse(data.ToString()));
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC写入{varname}信号时出现异常", ex);
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public override bool Read<T>(string varname, out T TagValue)
        {

            try
            {
                if (!adsClient.IsConnected)
                {
                    Connect();
                }
                int hander_read = adsClient.CreateVariableHandle(varname);
                if (typeof(T) == typeof(string))
                {
                    TagValue = (T)(adsClient.ReadAny(hander_read, typeof(string), new int[] { 100 }));
                }
                else
                {
                    TagValue = (T)(adsClient.ReadAny(hander_read, typeof(T)));
                }
            }
            catch
            {
                TagValue = default(T);
                //LogHelper.Fatal($"向倍福PLC读取{varname}信号时出现异常", ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 重写父类方法
        /// </summary>
        /// <param name="TagNameList"></param>
        /// <param name="TagValueList"></param>
        /// <returns></returns>
        public override bool ReadMultiTagValue<T>(string[] varnameList, out T[] TagValueArray)
        {
            TagValueArray = new T[varnameList.Length];
            Type dataType = typeof(T);
            try
            {
                if (!adsClient.IsConnected)
                {
                    Connect();
                }
                for (int i = 0; i < varnameList.Length; i++)
                {
                    int hander_read = adsClient.CreateVariableHandle(varnameList[i]);
                    if (dataType == typeof(string))
                    {
                        TagValueArray[i] = (T)(adsClient.ReadAny(hander_read, typeof(string), new int[] { 100 }));
                    }
                    else
                    {
                        TagValueArray[i] = (T)(adsClient.ReadAny(hander_read, dataType));
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.Fatal($"向倍福PLC读取多个信号时出现异常", ex);
                return false;
            }
            return true;
        }


        #region 地址方式读写
        /// <summary>
        /// 读beckhoff操作
        /// </summary>
        /// <param name="groupIndex"></param>
        /// <param name="offsetIndex"></param>
        /// <returns></returns>
        public string Read(int groupIndex, int offsetIndex)
        {
            if (adsClient.IsConnected)
            {
                try
                {
                    adsStream = new AdsStream(4);
                    br = new BinaryReader(adsStream);
                    adsClient.Read(groupIndex, offsetIndex, adsStream);
                    string result = br.ReadInt32().ToString();
                    return result;
                }
                catch (Exception ex)
                {
                    LogHelper.Fatal($"向倍福PLC读取信号时出现异常", ex);
                    return null;
                }
            }
            else
            {
                NoticeHelper.OutputMessageSend($"存在对倍福Read执行失败", OutputLevelModel.ERROR);
                return null;
            }

        }

        /// <summary>
        /// 写int字节数据到beckhoff
        /// </summary>
        /// <param name="groupIndex"></param>
        /// <param name="offsetIndex"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteInt(int groupIndex, int offsetIndex, int value)
        {
            try
            {
                if (adsClient.IsConnected)
                {
                    adsStream = new AdsStream(8);
                    bw = new BinaryWriter(adsStream);
                    adsStream.Position = 0;

                    bw.Write(value);
                    adsClient.Write(groupIndex, offsetIndex, adsStream);
                    return true;
                }
                else
                {
                    NoticeHelper.OutputMessageSend($"存在WriteInt执行失败", OutputLevelModel.ERROR);
                    return false;
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"WriteInt执行出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"WriteInt执行出现异常", ex);
                return false;
            }
        }
        /// <summary>
        /// 写string字节数据到beckhoff
        /// </summary>
        /// <param name="groupIndex"></param>
        /// <param name="offsetIndex"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteString(int groupIndex, int offsetIndex, string value)
        {
            try
            {
                if (adsClient.IsConnected)
                {
                    adsStream = new AdsStream(20);
                    bw = new BinaryWriter(adsStream);
                    adsStream.Position = 0;

                    bw.Write(value);
                    adsClient.Write(groupIndex, offsetIndex, adsStream);
                    return true;
                }
                else
                {
                    NoticeHelper.OutputMessageSend($"存在WriteString执行失败", OutputLevelModel.ERROR);
                    return false;
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"WriteString执行出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"WriteString执行出现异常", ex);
                return false;
            }
        }
        #endregion


        #region 变量名方式
        /// <summary>
        /// 变量名方式方式读beckhoff操作
        /// </summary>
        /// <param name="variableHandle"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string Read(int variableHandle, Type type)
        {
            if (adsClient.IsConnected)
            {
                try
                {
                    string result = adsClient.ReadAny(variableHandle, type).ToString();
                    return result;
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend($"倍福Read方法执行出现异常：{ex.Message}", OutputLevelModel.ERROR);
                    LogHelper.Fatal($"倍福Read方法执行出现异常", ex);
                    return null;
                }
            }
            else
            {
                NoticeHelper.OutputMessageSend("存在对倍福Read执行失败", OutputLevelModel.ERROR);
                return null;
            }
        }

        /// <summary>
        /// 变量名方式 写字节数据到beckhoff
        /// </summary>
        /// <param name="variableHandle"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteInt(int variableHandle, object value)
        {
            try
            {
                if (adsClient.IsConnected)
                {
                    adsClient.WriteAny(variableHandle, Convert.ToInt16(value));
                    return true;
                }
                else
                {
                    NoticeHelper.OutputMessageSend("存在WriteInt执行失败", OutputLevelModel.ERROR);
                    return false;
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"倍福WriteInt方法执行出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"倍福WriteInt方法执行出现异常", ex);
                return false;
            }
        }
        #endregion

        #region 读取结构体
        //读取struct类型的变量null --读取失败
        public ComplexStruct ReadStruct(string plcVariableName)
        {
            ComplexStruct result = null;
            try
            {
                int iHandleTemp = adsClient.CreateVariableHandle(plcVariableName);
                result = (ComplexStruct)(adsClient.ReadAny(iHandleTemp, typeof(ComplexStruct)));
                adsClient.DeleteVariableHandle(iHandleTemp);
            }
            catch
            {
                return null;
            }
            return result;
        }
        public ComplexStruct GetStruct(int[] RCordinationArr)
        {
            ComplexStruct structure = new ComplexStruct();
            structure.RCordinationArr = RCordinationArr;
            return structure;
        }
        #endregion



        /// <summary>
        /// 读结构体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public T CCDReadPLC<T>(int id)
        {
            try
            {
                T value = (T)adsClient.ReadAny(id, typeof(T));
                return value;
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"CCDReadPLC读取出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"CCDReadPLC读取出现异常", ex);
                return default(T);
            }
            finally
            {

            }
        }

        public T CCDReadPLC_array<T>(int id)
        {
            try
            {
                int[] arr = new int[40];
                T value = (T)adsClient.ReadAny(id, typeof(T), arr);
                return value;

            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }

        }

        public T ReadFromPLC1<T>(string str)
        {
            int id = 0;
            string st = "";
            st = str;
            try
            {
                id = adsClient.CreateVariableHandle(st);
                T value = (T)adsClient.ReadAny(id, typeof(T));
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {
            }
        }
        public bool WriteToPlc1(string str, int value)
        {
            int id = 0;
            string st = "";
            st = str;
            try
            {
                id = adsClient.CreateVariableHandle(st);
                adsClient.WriteAny(id, short.Parse(value.ToString()));
                return true;
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"执行WriteToPlc1方法出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Fatal($"执行WriteToPlc1方法出现异常", ex);
                return false;
            }

        }

        /// <summary>
        /// dwq 读取字符串
        /// </summary>
        /// <param name="varname">字符串 变量名</param>
        /// <param name="sid">字符串长度 变量名</param>
        /// <param name="val">输出字符串</param>
        /// <returns>输出字符串</returns>
        public int Read(string varname, string sid, out string val)
        {

            varname = string.Format("." + varname);
            sid = string.Format("." + sid);
            try
            {
                int hvar = adsClient.CreateVariableHandle(sid);

                AdsStream datastream = new AdsStream(4);
                BinaryReader br1 = new BinaryReader(datastream);
                datastream.Position = 0;
                //读取长度变量值
                adsClient.Read(hvar, datastream);
                int strlength = br1.ReadInt16();

                AdsStream abstream2 = new AdsStream(strlength + 1);
                BinaryReader br2 = new BinaryReader(abstream2, System.Text.ASCIIEncoding.ASCII);
                abstream2.Position = 0;

                int id = adsClient.CreateVariableHandle(varname);

                int length = adsClient.Read(id, abstream2);
                string Orival = new string(br2.ReadChars(length));
                val = Orival.Trim("\0".ToCharArray());//去掉无意义符号

                //val= Read(id, 20);
                //val = (adsClient.ReadAny(id, varname.GetType())).ToString();
                return 0;

            }
            catch
            {
                val = null;
                return 1;
                //throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// dwq 读取字符串
        /// </summary>
        /// <param name="varname">字符串名</param>
        /// <param name="sid">字符串长度</param>
        /// <param name="val">输出字符串</param>
        /// <returns>输出字符串</returns>
        public string Read(string varname, int sid, out string val)
        {

            varname = string.Format("." + varname);
            //sid = string.Format("." + sid);
            try
            {
                int strlength = sid;
                AdsStream abstream2 = new AdsStream(strlength + 1);
                BinaryReader br2 = new BinaryReader(abstream2, System.Text.ASCIIEncoding.ASCII);
                abstream2.Position = 0;

                int id = adsClient.CreateVariableHandle(varname);

                int length = adsClient.Read(id, abstream2);
                string Orival = new string(br2.ReadChars(length));
                val = Orival.Trim("\0".ToCharArray()); //去掉无意义符号

                //val= Read(id, 20);
                //val = (adsClient.ReadAny(id, varname.GetType())).ToString();
                return val;

            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// 读取float(real) 数组
        /// </summary>
        /// <param name="varname">数组 标签变量名</param>
        /// <param name="len">数组长度 标签变量名</param>
        /// <returns>数组</returns>
        public float[] ReadFloatArray(string varname, int len)
        {
            try
            {
                float[] arrayList = new float[len];
                varname = string.Format("." + varname);

                int strlength = len;
                AdsStream abstream = new AdsStream(4 * len);
                BinaryReader br = new BinaryReader(abstream);
                abstream.Position = 0;

                int id = adsClient.CreateVariableHandle(varname);

                int length = adsClient.Read(id, abstream);

                for (int j = 0; j < len; j++)
                {
                    arrayList[j] = br.ReadSingle();
                }

                #region if2
                //string[] varnameArray = new string[len];
                ////AdsStream abstream = new AdsStream(2 * len);
                ////BinaryReader br2 = new BinaryReader(abstream);
                ////abstream.Position = 0;

                //int[] iArray = new int[len];               

                //for (int i = 0; i < len; i++)
                //{

                //    varnameArray[i] = string.Format("." + varname + "[{0}]", i);

                //    iArray[i] = adsClient.CreateVariableHandle(varnameArray[i]);                

                //    adsClient.Read(iArray[i], abstream);

                //    arrayList[i] = br.ReadSingle();

                //}
                #endregion


                return arrayList;

            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// 写float(real)数组
        /// </summary>
        /// <param name="varname"></param>
        /// <param name="value"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public int WriteFloatArray(string varname, float[] value, int len)
        {
            try
            {
                float[] arrayList = new float[len];
                varname = string.Format("." + varname);

                int strlength = len;
                AdsStream abstream = new AdsStream(4 * len);
                BinaryWriter bw = new BinaryWriter(abstream);
                abstream.Position = 0;

                int id = adsClient.CreateVariableHandle(varname);

                adsClient.Write(id, abstream);

                for (int j = 0; j < len; j++)
                {
                    arrayList[j] = br.ReadSingle();
                }

                return 0;

            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// 读int数组
        /// </summary>
        /// <param name="varname"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public int[] ReadIntArray(string varname, int len)
        {

            varname = string.Format("." + varname);
            //sid = string.Format("." + sid);
            try
            {
                int strlength = len;
                AdsStream abstream = new AdsStream(4 * len);
                BinaryReader br2 = new BinaryReader(abstream);
                abstream.Position = 0;

                int id = adsClient.CreateVariableHandle(varname);

                int length = adsClient.Read(id, abstream);

                int[] arrayList = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arrayList[i] = br2.ReadInt32();
                }

                return arrayList;

            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC失败" + ex.Message);
            }
            finally
            {

            }
        }


        public object Read(string varname, string dataType, int length)
        {

            try
            {
                if (!adsClient.IsConnected)
                {
                    Connect();
                }
                int hander_read = adsClient.CreateVariableHandle(varname);
                switch (dataType)
                {
                    case "string":
                        string strData = (string)(adsClient.ReadAny(hander_read, typeof(string), new int[] { length }));
                        return strData;
                    case "bool":
                        bool blData = (bool)(adsClient.ReadAny(hander_read, typeof(bool)));
                        return blData;
                    case "int":
                        int iData = (int)(adsClient.ReadAny(hander_read, typeof(int)));
                        return iData;
                    case "double":
                        double dData = (double)(adsClient.ReadAny(hander_read, typeof(double)));
                        return dData;
                    case "float":
                        float fData = (float)(adsClient.ReadAny(hander_read, typeof(float)));
                        return fData;
                    default:
                        return "false";
                }
            }
            catch
            {
                ////WriteLog.WriteLogFileToUI("PLC Read Error ->" + ip + " - " + varname, Color.Red);
                switch (dataType)
                {
                    case "string":
                        return "";
                    case "bool":
                        return false;
                    case "int":
                        return 0;
                    case "double":
                        return 0;
                    case "float":
                        return 0;
                    default:
                        return "false";
                }
            }
        }

        public int GetStructIDAddress(string variableName)
        {
            try
            {
                return (int)adsClient.CreateVariableHandle(variableName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
