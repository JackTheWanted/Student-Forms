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
   
    public partial class StudentDetails : Form
    {
        int index;
        public StudentDetails(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            lblFirstNameInfo.Text = StudentForms.students[index].FirstName;
            lblLastNameInfo.Text = StudentForms.students[index].LastName;
            lblStudentNumInfo.Text = StudentForms.students[index].StudentNumber + "";
            lblEmailInfo.Text = StudentForms.students[index].Email;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
