using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterClass
    {
        CoreClass core = new CoreClass();

        public List<string> ChuanHoaListChuoi(List<string> danhSach)
        {
            List<string> newList = new List<string>();
            foreach (string item in danhSach)
            {
                newList.Add(core.ChuanHoaChuoi(item));
            }
            return newList;
        }
    }
}
