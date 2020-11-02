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

    public struct Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Price: " + this.Price + ", Count: " + this.Count;     
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            if(add.ShowDialog() == DialogResult.OK)
            {
                Product product = new Product()
                {
                    Count = int.Parse(add.ProductCount),
                    Price = float.Parse(add.ProductPrice),
                    Name = add.ProductName
                };
                this.listProductForMen.Items.Add(product);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listProductForMen.Items.Remove(this.listProductForMen.SelectedItem);
        }
    }
}
