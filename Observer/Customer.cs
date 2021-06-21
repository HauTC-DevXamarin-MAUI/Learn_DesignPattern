using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    class Customer:ObseverClass
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        //de triển khai obsever thì cần tạo thêm cho customer 1 cái hàm:
        public override void ObseverInfo(string info)
        {
            MessageBox.Show("Thong bao cho KH : "+ Name+ "\nCo sdt la: "+ PhoneNumber+"\nThong tin sp: " + info);
        }
        public Customer(string name, string phone)
        {
            this.Name = name;
            this.PhoneNumber = phone;
        }
    }
}
