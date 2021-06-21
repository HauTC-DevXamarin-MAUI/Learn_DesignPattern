using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{//Khi co 1 sp: nhu Ql ban hang. co ds KH , Email. Khi có sản phẩm mới ra thị trường
    //Và nếu KH có đk với Cửa hàng là sẽ nhận thông tin của SP mới đó
    // =>Obsever
    // ng nhận k biết ai gửi cho mình
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product sp = new Product("Iphone 12 pro max");

            Customer cus1 = new Customer("Hau", "113");
            Customer cus2 = new Customer("HauDepTrai", "113");
            sp.AddCustomer(cus1);
            sp.AddCustomer(cus2);

            sp.ObseverInfo("");
        }
    }
}
