using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ClassB : MyClass, ICloneable
    {
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public object Clone()
        {
            ClassB newClass = base.Clone() as ClassB;
            newClass.Address = this.address;

            return newClass;
        }
        public override string ToString()
        {
            return base.ToString() + "| Info: " + this.address;
        }
    }
}
