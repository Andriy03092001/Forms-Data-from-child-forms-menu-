using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            this.btnLight.Checked = false;
            this.btnDark.Checked = true;
            this.BackColor = Color.Black;
            this.menuStrip1.BackColor = Color.Gray;
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            this.btnDark.Checked = false;
            this.btnLight.Checked = true;
            this.BackColor = SystemColors.Window;
            this.menuStrip1.BackColor = Color.White;
        }

        private void откритьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open file!");
        }
    }
}
