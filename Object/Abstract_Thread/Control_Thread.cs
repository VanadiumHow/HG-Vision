using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace BaseThread
{
    /// <summary>
    /// 所有具体线程的抽象类基类，要求派生类实现Initialize和Deinitialize方法、要求实现Run方法
    /// </summary>
    public abstract class Control_Thread : BaseThread, IBaseThread
    {
        Thread th;
        bool m_bStopThread = false;

        /// <summary>
        /// 线程循环延时时间，单位毫秒，若为0则不延时，若为-1则不循环，若为-1以外的负数则报错
        /// </summary>
        private int m_nDelayTime = 0;

        private string m_strThName = "";
        public bool IsBackground
        {
            set { if (th != null) th.IsBackground = value; }
        }
        public bool IsAlive
        {
            get {
                if (th == null)
                    return false;
                else
                    return th.IsAlive;
            }
        }
        public void SetApartmentState(ApartmentState state)
        {
            if (th != null)
            {
                th.SetApartmentState(state);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nDelayTime">线程循环延时时间，单位毫秒，若为0则不延时，若为-1则不循环，若为-1以外的负数则报错</param>
        /// <param name="strName">线程名</param>
        /// <returns></returns>
        protected override bool Start(int nDelayTime, string strName = "")
        {
            this.m_strThName = strName;
            if (th == null)
            {

                m_nDelayTime = nDelayTime;
                try
                {
                    this.th = new Thread(new ThreadStart(this.Th1Process));
                    this.th.Start();
                }
                catch
                {

                }
            }
            else if (th.IsAlive == false)
            {
                m_nDelayTime = nDelayTime;
                try
                {
                    this.th = new Thread(new ThreadStart(this.Th1Process));
                    this.th.Start();
                }
                catch
                {

                }
            }


            return true;
        }

        protected override void Stop()
        {
            if (th == null)
                return;
            if (th.IsAlive == false)
            {
                this.th = null;
                return;
            }
            this.m_bStopThread = true;
            if (this.th != null)
            {
                this.th.Join(500);
                this.th = null;
            }
        }
        public abstract void Initialize();
        public abstract void Deinitialize();

        //public void Dispose()
        //{
        //    Stop();
        //}
        private void Th1Process()
        {
            m_bStopThread = false;
            while (m_bStopThread == false)
            {
                try
                {

                    Run(); // 子类实现
                    if (m_nDelayTime == -1)
                    {
                        break; // 如果延时为-1，则不循环
                    }
                    if (m_nDelayTime < 0)
                    {
                        MessageBox.Show($"线程循环延时不能为负值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Thread.Sleep(m_nDelayTime);
                }
                catch (Exception ex)
                {
                    // 用户端简洁提示
                    MessageBox.Show($"操作失败: {ex.Message}", "错误",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_bStopThread = true; // 出现异常则停止线程
                }
            }
        }
    }
}
