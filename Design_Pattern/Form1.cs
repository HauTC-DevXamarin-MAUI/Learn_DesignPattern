using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern
{//Link tham khao:http://nthoai.blogspot.com/2008/05/su-dung-singleton-trong-csharp.html
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SingletonClass.Instance.Demo();
            SingletonClass.Instance.PrintString("Dung vay Dung vay");
        }


    }
}
