using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CoreClass
    {
        public string ChuanHoaChuoi(string chuoi)
        {
            return chuoi.ToUpper().Trim();
        }
    }
}
