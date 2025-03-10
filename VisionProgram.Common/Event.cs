using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


/****************************************************************

*
*****************************************************************/

namespace VisionProgram.Common
{
    /// <summary>
    /// 封装事件调用的辅助类
    /// </summary>
    public class MySyncMessage
    {
        public event EventHandler SyncEvent;

        public void SendMessage(object sender, EventArgs message)
        {
            if (SyncEvent == null)
                return;

            Delegate[] delegAry = SyncEvent.GetInvocationList();
            foreach (EventHandler deleg in delegAry)
            {
                deleg.Invoke(sender, message);
            }

        }
    }

    public class MyAsyncMessage
    {
        // 异步事件
        public event EventHandler AsyncEvent;

        public void SendMessage(object sender, EventArgs message)
        {
            if (AsyncEvent == null)
                return;

            Delegate[] delegAry = AsyncEvent.GetInvocationList();
            foreach (EventHandler deleg in delegAry)
            {
                deleg.BeginInvoke(sender, message, null, null);
            }
        }
    }

    public class MyEventArgs : EventArgs
    {
        public object obj;
        public MyEventArgs(object obj1)
        {
            obj = obj1;
        }
    }
}

