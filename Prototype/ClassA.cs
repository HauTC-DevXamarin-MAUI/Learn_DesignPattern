using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ClassA:MyClass,ICloneable
    {
        private string info;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public object Clone()
        {
            ClassA newClass = base.Clone() as ClassA;
            newClass.Info = this.info;

            return newClass;
        }
        public override string ToString()
        {
            return base.ToString() + "| Info: " + this.info;
        }
    }
}
