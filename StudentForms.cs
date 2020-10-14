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
    public partial class StudentForms : Form
    {
        public static List<Student> students = new List<Student>();
        public StudentForms()
        {
            InitializeComponent();
        }

        private void StudentForms_Load(object sender, EventArgs e)
        {           
            students.Add(new Student("Jack", "Carlson"));
            students.Add(new Student("Cole", "Cantwell"));
            students.Add(new Student("Tilson", "Beatie"));
            students.Sort();
            lstStudents.DataSource = students;
            
        }       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent frmAddStudent = new AddStudent();
            frmAddStudent.ShowDialog();
            ResetList();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            StudentDetails frmStudentDetails = new StudentDetails(lstStudents.SelectedIndex);
            frmStudentDetails.ShowDialog();
            ResetList();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudent frmEditStudent = new EditStudent(lstStudents.SelectedIndex);
            frmEditStudent.ShowDialog();
            ResetList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex >= 0)
            {
                students.RemoveAt(lstStudents.SelectedIndex);
                ResetList();
            }
            
        }
        private void ResetList()
        {
            students.Sort();
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }
    }
}
