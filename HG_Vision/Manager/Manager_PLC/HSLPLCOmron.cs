using System;
using System.Collections.Generic;
using System.Text;
using HslCommunication.Profinet.Omron;
using HslCommunication;
using Obj.Obj_File;
using HG_Vision.Contol.Control_PLC;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_PLC
{
    public class HSLPLCOmron
    {
        public OmronFinsNet NJPLC;

        public bool _isPLCConnect = false;
        HslCommunication.OperateResult result = new HslCommunication.OperateResult();

        public int PLCNum = 1;
        /// <summary>
        /// PLC配置类
        /// </summary>
        public PLCConfiguration _plcConfiguration = new PLCConfiguration();

        public List<List<PLCSignalInfo>> L_PLCSignalInfoList = new List<List<PLCSignalInfo>>(); //存储信号变量容器
        /// <summary>
        /// PLC信息的集合
        /// </summary>
        public List<PLCConfiguration.PLCInfo> L_PLCInfo = new List<PLCConfiguration.PLCInfo>();
        //加载ini



        public HSLPLCOmron()
        {
            try
            {
                _plcConfiguration.AnalysisPlcCommConfig(ref L_PLCInfo, ref L_PLCSignalInfoList);
                NJPLC = new OmronFinsNet(L_PLCInfo[0].IP, Convert.ToInt32(L_PLCInfo[0].Port));
                NJPLC.SA1 = Convert.ToByte(L_PLCInfo[0].SA1);
                NJPLC.DA1 = 5;
                NJPLC.DA2 = 0;
                NJPLC.ByteTransform.DataFormat = HslCommunication.Core.DataFormat.CDAB;
                NJPLC.ByteTransform.IsStringReverse = true;


            }
            catch (Exception ex)
            {
                LogHelper.Fatal("PLC实例化出现异常", ex);
            }
        }

        public bool ConnectionState()
        {
            return _isPLCConnect;
        }

        public bool Connect()
        {
            try
            {
                result = NJPLC.ConnectServer();
                _isPLCConnect = result.IsSuccess;
            }
            catch (Exception ex)
            {
                _isPLCConnect = false;
                LogHelper.Fatal("连接欧姆龙PLC出现异常", ex);
            }
            return _isPLCConnect;
        }

        public void Dispose()
        {
            NJPLC.Dispose();
        }
        public bool Write(string address, byte[] value)
        {
            try
            {
                if (_isPLCConnect)
                {
                    result = NJPLC.Write(address, value);
                    if (result.IsSuccess)
                        return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public bool WriteInt(string address, int value)
        {
            try
            {
                if (_isPLCConnect)
                {
                    result = NJPLC.Write(address, value);
                    if (result.IsSuccess)
                        return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public bool WriteString(string address, string value, int length)
        {
            try
            {
                if (_isPLCConnect)
                {
                    result = NJPLC.Write(address, value, length, Encoding.ASCII);
                    if (result.IsSuccess)
                        return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public byte[] Read(string address, ushort length)
        {
            try
            {
                if (_isPLCConnect)
                {
                    OperateResult<byte[]> read;
                    read = NJPLC.Read(address, length);
                    if (read.IsSuccess)
                    {
                        return read.Content;
                    }
                    else
                    {
                        Connect();
                        LogHelper.Fatal("读取二维码出现异常");
                        return null;
                    }
                }
                else
                {
                    Connect();
                    if (_isPLCConnect)
                    {
                        OperateResult<byte[]> read;
                        read = NJPLC.Read(address, length);
                        if (read.IsSuccess)
                        {
                            return read.Content;
                        }
                        else
                        {
                            Connect();
                            LogHelper.Fatal("读取二维码出现异常");
                            return null;
                        }
                    }
                }
            }
            catch
            {
                LogHelper.Fatal("读取二维码出现异常");
                return null;
            }
            LogHelper.Fatal("读取二维码出现异常");
            return null;
        }
        public string ReadString(string address, ushort length)
        {
            try
            {
                if (_isPLCConnect)
                {
                    OperateResult<string> read;
                    read = NJPLC.ReadString(address, length);
                    if (read.IsSuccess)
                    {
                        return read.Content;
                    }
                    else
                    {
                        Connect();
                        LogHelper.Fatal("读取二维码出现异常");
                        return "Error";
                    }
                }
                else
                {
                    Connect();
                    if (_isPLCConnect)
                    {
                        OperateResult<string> read;
                        read = NJPLC.ReadString(address, length);
                        if (read.IsSuccess)
                        {
                            return read.Content;
                        }
                        else
                        {
                            Connect();
                            LogHelper.Fatal("读取二维码出现异常");
                            return "Error";
                        }
                    }
                }
            }
            catch
            {
                LogHelper.Fatal("读取二维码出现异常");
                return "Error";
            }
            LogHelper.Fatal("读取二维码出现异常");
            return "Error";
        }


        public Int16 ReadInt16(string address)
        {
            try
            {
                if (_isPLCConnect)
                {
                    OperateResult<Int16> read;
                    read = NJPLC.ReadInt16(address);

                    if (read.IsSuccess)
                    {
                        return read.Content;

                    }
                    else
                    {
                        Connect();
                        LogHelper.Fatal("读取夹具号出现异常");
                        return 0;
                    }
                }
                else
                {
                    Connect();
                    if (_isPLCConnect)
                    {
                        OperateResult<Int16> read;
                        read = NJPLC.ReadInt16(address);
                        if (read.IsSuccess)
                        {
                            return read.Content;
                        }
                        else
                        {
                            Connect();
                            LogHelper.Fatal("读取夹具号出现异常");
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                LogHelper.Fatal("读取夹具号出现异常");
                return 0;
            }
            LogHelper.Fatal("读取夹具号出现异常");
            return 0;
        }

        public float ReadFloat(string address)
        {
            try
            {
                if (_isPLCConnect)
                {
                    OperateResult<float> read;
                    read = NJPLC.ReadFloat(address);

                    if (read.IsSuccess)
                    {
                        return read.Content;

                    }
                    else
                    {
                        Connect();
                        LogHelper.Fatal("读取极耳长度出现异常");
                        return 0;
                    }
                }
                else
                {
                    Connect();
                    if (_isPLCConnect)
                    {
                        OperateResult<float> read;
                        read = NJPLC.ReadFloat(address);
                        if (read.IsSuccess)
                        {
                            return read.Content;
                        }
                        else
                        {
                            Connect();
                            LogHelper.Fatal("读取极耳长度出现异常");
                            return 0;
                        }
                    }
                }
            }
            catch
            {
                LogHelper.Fatal("读取极耳长度出现异常");
                return 0;
            }
            LogHelper.Fatal("读取极耳长度出现异常");
            return 0;
        }
    }
}
