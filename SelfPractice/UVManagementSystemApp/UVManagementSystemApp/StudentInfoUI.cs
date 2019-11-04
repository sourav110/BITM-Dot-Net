using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVManagementSystemApp.Models;
using UVManagementSystemApp.BLL;

namespace UVManagementSystemApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        private StudentManager studentManager = new StudentManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.StudentName = nameTextBox.Text;
            student.RegNo = regNoTextBox.Text;
            student.PhoneNo = phoneTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Department = departmentTextBox.Text;

            string message = studentManager.SaveStudent(student);
            messageLabel.Text = message;

            ShowStudentListView();

            ClearTextBox();
        }

        private void ClearTextBox()
        {
            nameTextBox.Text = String.Empty;
            regNoTextBox.Text = String.Empty;
            phoneTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            departmentTextBox.Text = String.Empty;
        }

        private void StudentInfoUI_Load(object sender, EventArgs e)
        {
            ShowStudentListView();
        }

        private void ShowStudentListView()
        {
            studentListView.Items.Clear();

            List<Student> students = studentManager.GetAllStudents();

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student.StudentName;
                item.SubItems.Add(student.RegNo);
                item.SubItems.Add(student.PhoneNo);
                item.SubItems.Add(student.Email);
                item.SubItems.Add(student.Department);

                studentListView.Items.Add(item);
            }
        }
    }
}
