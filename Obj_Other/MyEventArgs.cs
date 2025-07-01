using System;

/****************************************************************

*
*****************************************************************/

namespace Obj.Obj_Other
{
    public class MyEventArgs : EventArgs
    {
        public object obj;
        public MyEventArgs(object obj1)
        {
            obj = obj1;
        }
    }
}

