using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Forms
{
    public partial class AddStudent : Form
    {
        string frstName;
        string lstName;
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstNameAdd.Text.Trim() != "")
            {
                frstName = txtFirstNameAdd.Text.Trim();
            }

            else
            {
                lblAddMessage.Text = "Please enter a valid first name";
            }

            if (txtLastNameAdd.Text.Trim() != "")
            {
                lstName = txtLastNameAdd.Text.Trim();
            }

            else
            {
                lblAddMessage.Text = "Please enter a valid last name";
            }

            if (txtFirstNameAdd.Text.Trim() != "" && txtLastNameAdd.Text.Trim() != "")
            {
                StudentForms.students.Add(new Student(frstName, lstName));
                this.Dispose();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
