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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Blue;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.Green;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.ForeColor = Color.Red;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.ForeColor = Color.Blue;
        }

        private void зелёныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.ForeColor = Color.Green;
        }
    }
}
