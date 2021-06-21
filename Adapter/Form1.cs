using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;

                AdapterClass adapter = new AdapterClass();

                StreamReader sr = new StreamReader(dialog.FileName);
                List<string> danhSach = new List<string>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    danhSach.Add(line);
                }
                comboBox1.DataSource = null;
                comboBox1.DataSource = adapter.ChuanHoaListChuoi(danhSach);
            }
        }
    }
}
