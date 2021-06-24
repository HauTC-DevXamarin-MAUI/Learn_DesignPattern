using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{// hiểu nôm na: xd, mở rộng  các lớp, các phương thức cũ để thành cái mới phù hợp vs yêu cầu dựa trên cái cũ
    //Tái sd giao diện cũ, hạn chế, giảm thiểu viết lại code
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
