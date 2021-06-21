using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CoreClass:ACore
    { //vd: code nay build ra dll cho KH roi, k sua code dc. de chay code nay k loi thi tao them cai proxy
        private string name;
        public override string GetName()
        {
            return this.name;
        }

        public CoreClass(string name)
        {
            this.name = name;
        }
    }
}
