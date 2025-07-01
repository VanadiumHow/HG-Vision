using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BaseThread
{
    public abstract class Control_Thread : BaseClass, IDisposable
    {
        Thread th;
        bool m_bStopThread = false;
        int m_nDelayTime = 0;
        private string m_strThName = "";

        public override bool Start(int nDelayTime, string strName = "")
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

        public override void Stop()
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
        public void Dispose()
        {
            Stop();
        }
        private void Th1Process()
        {
            m_bStopThread = false;
            while (m_bStopThread == false)
            {
                try
                {

                    Run(); // 子类实现
                    System.Threading.Thread.Sleep(m_nDelayTime);
                }
                catch
                {

                }

            }
            //             this.th = null;
        }
    }
}
