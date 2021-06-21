using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Form1 : Form
    {//Proxy: (nguoi dai dien) dai dien chuc nang cho mot lop khac

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CoreClass core = new CoreClass("Hau dep trai qua do. ");
            //textBox1.Text = core.GetName();

            CoreProxyClass core = new CoreProxyClass(checkBox1.Checked);
            textBox1.Text = core.GetName();
        }
    }
}
