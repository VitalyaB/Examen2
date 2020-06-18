using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен.Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtTabl.Text);
            Form2 frm = new Form2();
            frm.Show();
            for (int i = 0; i < 10; i++)
            {
                frm.listBox1.Items.Insert(i, n + "*" + (i + 1) + "=" + ((i + 1) * n).ToString());
            }
        }
    }
}
