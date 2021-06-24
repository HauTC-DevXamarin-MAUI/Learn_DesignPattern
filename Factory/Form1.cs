using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        //Giả sử: nhà có 1 ng mang thai.
        //khi mà bạn đi nói "nhà tôi có ng mang thai"
        //thì ng khác chắc chắn là ng mang thai đó là phụ nữ
        //=> k đưa cho họ nhiều thông tin họ cũng biết những thông tin cốt yếu. =>factory
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            People peoleOne = new PeopleWithDog();
            peoleOne.SetPet();
            People peoleTwo = new PeopleWithCat();
            peoleTwo.SetPet();

            peoleOne.PetInfo();
            peoleTwo.PetInfo();
        }
    }
}
