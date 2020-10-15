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
    public partial class EditStudent : Form
    {
        int index;
        public EditStudent(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnEditFirst_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() != "")
            {
                StudentForms.students[index].FirstName = txtFirstName.Text.Trim();
                this.Dispose();
            }
            else
            {
                lblEditMessage.Text = "Invalid first name";
            }
        }

        private void btnEditLast_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Trim() != "")
            {
                StudentForms.students[index].LastName = txtLastName.Text.Trim();
                this.Dispose();
            }
            else
            {
                lblEditMessage.Text = "Invalid last name";
            }
        }

        private void btnEditBoth_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "")
            {
                if (txtLastName.Text.Trim() != "")
                {
                    StudentForms.students[index].LastName = txtLastName.Text.Trim();
                    StudentForms.students[index].LastName = txtLastName.Text.Trim();
                    this.Dispose();
                }
                
            }
            else
            {
                lblEditMessage.Text = "Either invalid first name or invalid last name";
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            lblPrevStudentName.Text = "The students current name is " + StudentForms.students[index].FirstName + " " + StudentForms.students[index].LastName;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
