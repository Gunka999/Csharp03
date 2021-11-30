using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11._28._2021
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            students = new List<Student>();
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string fname = txtName.Text.Trim();
            string fsurname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                Student student = new Student
                {
                    Name = fname,
                    Surname = fsurname,
                    Email = email
                };
                students.Add(student);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please fill valid values for student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillStudentList();
        }

        private void FillStudentList()
        {
            listStudent.Items.Clear();
            foreach (var item in students)
            {
                listStudent.Items.Add(item.Fullname + " " + item.Email);
            }
        }
    }
}
