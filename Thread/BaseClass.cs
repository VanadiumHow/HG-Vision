using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaseThread
{
    public abstract class BaseClass
    {
        public abstract bool Start(int nDelayTime, string strName = "");
        public abstract void Stop();
        public abstract void Run();
    }
}
