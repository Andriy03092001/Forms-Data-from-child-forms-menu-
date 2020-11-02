using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get
            {
                return this.txtName.Text;
            }
        }

        public string ProductPrice
        {
            get
            {
                return this.txtPrice.Text;
            }
        }

        public string ProductCount
        {
            get
            {
                return this.txtCount.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.txtCount.Text) &&
               !String.IsNullOrEmpty(this.txtName.Text) &&
               !String.IsNullOrEmpty(this.txtPrice.Text)) {
             
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please, enter all fields");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
