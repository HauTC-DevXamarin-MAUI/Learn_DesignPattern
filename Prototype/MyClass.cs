using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class MyClass : ICloneable
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Tao ra 1 thuc the moi tu chính thằng đang có sẵn
        public object Clone()
        {
            return new MyClass { Name = this.name, Id = this.id };
        }
        public override string ToString()
        {
            return "ID: " + this.id + " | " +"Name: "+this.name;
        }
    }
}
