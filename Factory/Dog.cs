using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Dog:Pet
    {
        private string name;
        public override void SetName(string name)
       {
           this.name = name;
        }
        public override string Talk()
        {
            return name;
        }
        public Dog(string name)
        { this.name = name; }
    }
}
