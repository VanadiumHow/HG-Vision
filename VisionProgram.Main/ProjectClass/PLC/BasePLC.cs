using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Common;
using VisionProgram.Models.VModels;


/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.ProjectClass.PLC
{
    public abstract class BasePLC
    {
        public int PLCNumber;//在所有PLC中的索引

        public string PLCDescription;//PLC描述

        public string PLCType;//plc类型

        public bool PLCConnectState = false;//当前PLC与CCD的连接状态

        public int PLCHand = 0; //当前CCD接收PLC发送的握手信号

        private DateTime _lastTime = DateTime.Now.AddSeconds(-2);//记录当前PLC业务类上一次握手保存时间

        private DateTime _currentTime;//记录当前PLC业务类握手时间

        private bool _isWarningOfReconn = false;//是否已经发送重连提醒 

        public BasePLC(string plcType, int number, string description)
        {
            this.PLCType = plcType;
            this.PLCNumber = number;
            this.PLCDescription = description;
        }


        /// <summary>
        /// 获取PLC状态
        /// </summary>
        /// <returns></returns>
        public abstract bool ConnectionState();

        /// <summary>
        /// PLC连接
        /// </summary>
        /// <returns></returns>
        public abstract bool Connect();

        /// <summary>
        /// PLC销毁
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// 写入PLC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="val"></param>
        public abstract bool WriteToPlc<T>(string name, T val);

        /// <summary>
        /// 写入PLC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="val"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public abstract bool Write<T>(string varname, T val);

        /// <summary>
        /// 读取PLC
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public abstract bool Read<T>(string TagName, out T TagValue);


        /// <summary>
        /// 读取多PLC信号
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varname"></param>
        /// <param name="TagValue"></param>
        /// <returns></returns>
        public abstract bool ReadMultiTagValue<T>(string[] varnameList, out T[] TagValueArray);


        #region PLC连接
        /// <summary>
        /// PLC连接
        /// </summary>
        public bool PlcConnect(string hangIn = "")
        {
            try
            {
                if (!_isWarningOfReconn)
                {
                    SendPLCMessage($"正在尝试连接{PLCDescription}...", ConstantModel.OK);
                    _isWarningOfReconn = true;
                }
                //如果是倍福
                if (PLCType == "Twincat")
                {
                    bool TwincatPLCConnectState = false;
                    if (!PLCConnectState)
                    {
                        bool back = Connect();
                        TwincatPLCConnectState = back;
                    }
                    if (TwincatPLCConnectState)
                        PLCConnectState = Write<Int16>(hangIn, 1);
                }
                //如果是欧姆龙
                else if (PLCType == "Omron")
                {
                    if (!PLCConnectState)
                    {
                        bool back = Connect();
                        PLCConnectState = back;
                    }
                }

                if (PLCConnectState)
                    _isWarningOfReconn = false;
                return PLCConnectState;
            }
            catch (Exception ex)
            {
                SendPLCMessage($"连接PLC{PLCDescription}出现异常。原因：" + ex.Message, false);
                LogHelper.Error($"连接PLC{PLCDescription}出现异常", ex);
                return false;
            }
        }
        #endregion

        #region PLC握手
        /// <summary>
        /// 时间判断是否PLC握手交互
        /// </summary>
        /// <param name="handIn"></param>
        /// 
        public void JudgePlcShakehands(string handIn)
        {
            _currentTime = DateTime.Now;
            if (1000 <= (_currentTime - _lastTime).TotalMilliseconds)
            {
                PlcShakehands(handIn);
                _lastTime = _currentTime;
            }
        }

        /// <summary>
        /// 握手逻辑（例子）
        /// </summary>
        /// <param name="handIn"></param>
        public void PlcShakehands(string handIn)
        {
            try
            {
                bool strR;
                Read<bool>(handIn, out strR);
                PLCHand = !strR ? 1 : 2;
                if (!Write<bool>(handIn, !strR))
                {
                    PLCConnectState = false;
                    PLCHand = 0;
                }
            }
            catch (Exception ex)
            {
                PLCConnectState = false;
                SendPLCMessage("异常：PLC握手信号写入失败，PLC断开连接。原因：" + ex.Message, false);
            }
        }
        #endregion

        #region 实时监听信号多读
        public void ReadMultiSignal(string[] signals, out object[] objVale)
        {
            objVale = new object[signals.Length];
            ReadMultiTagValue(signals, out objVale);
        }

        #endregion

        #region 简化发送PLC流程记录
        /// <summary>
        /// 简化发送PLC流程记录
        /// </summary>
        /// <param name="msg">信息</param>
        /// <param name="isOK">是OK信息还是NG信息</param>
        public void SendPLCMessage(string msg, bool isOK = true)
        {
            NoticeHelper.PLCMessageSend(msg, isOK, PLCNumber);
        }
        #endregion

        /// <summary>
        /// PLC业务类退出
        /// </summary>
        public virtual void Exit() { }
    }
}
