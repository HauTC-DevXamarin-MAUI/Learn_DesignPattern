using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //vd: neu la admin,QL moi sd ham core dc
    class CoreProxyClass:ACore
    {
        bool isAdmin = false;
        public override string GetName() 
        {
            if (isAdmin )
            {
                CoreClass core = new CoreClass("Hau van dep trai");
                return core.GetName();
            }
            return null;
        }
        public CoreProxyClass(bool isadmin)
        {
            this.isAdmin = isadmin;
        }
    }
}
