using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class PeopleWithCat:People
    {
        public override void SetPet()
        {
            myPet = new Cat("Cat mew mew");
        }
    }
}
