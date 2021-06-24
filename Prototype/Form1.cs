using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        //Prototype: vd co 1 bien can sd lai, muon tao 1 bien khac y nhu bien do .
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass myclass = new MyClass();
            myclass.Id = "1";
            myclass.Name = "1";
            MessageBox.Show(myclass.ToString());

            ClassA classA = new ClassA();
            classA.Id = "2";
            classA.Name = "2";
            classA.Info = "2";
            MessageBox.Show(classA.ToString());

            ClassB lassB = new ClassB();
            lassB.Id = "3";
            lassB.Name = "3";
            lassB.Address = "3";
            MessageBox.Show(lassB.ToString());
        }
    }
}
