using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProgram.Main.ProjectClass.PLC
{  
    /// <summary>
     ///抽象量， PLC变量定义
     /// </summary>
    public abstract class PLCVar
    {
        public string Name;
        public Type Type;
        public string Desc;
        public PLCVar(string name, string desc)
        {
            this.Name = name;
            this.Desc = desc;
        }
        public abstract void SetValue(object value);
        public abstract object GetValue();
    }
    public class PLCVar<T> : PLCVar
    {
        public T Value;
        public PLCVar(string name, string desc) : base(name, desc)
        {
            Type = typeof(T);
        }

        public override void SetValue(object value)
        {
            Value = (T)Convert.ChangeType(value, typeof(T));
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}
