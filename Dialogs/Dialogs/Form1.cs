using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            if(addStudentForm.ShowDialog() == DialogResult.OK)
            {
                this.listStudents.Items.Add(addStudentForm.NewName);
            }
        }
    }
}
