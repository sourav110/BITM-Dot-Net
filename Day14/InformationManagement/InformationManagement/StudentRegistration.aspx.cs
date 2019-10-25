﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InformationManagement.BLL;
using InformationManagement.Models;

namespace InformationManagement
{
    public partial class StudentInfoUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        StudentManager studentManager = new StudentManager();       
        

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;

            Student student = new Student(name, regNo, email, mobileNo, age, address);

            messageLabel.Text = studentManager.SaveStudent(student);
            messageLabel.ForeColor = Color.Brown;

            ClearField();
        }


        protected void updateButton_Click(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;

            Student student = new Student(name, regNo, email, mobileNo, age, address);

            messageLabel.Text = studentManager.UpdateStudent(student);

            ClearField();
        }


        protected void deleteButton_Click(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;

            Student student = new Student(name, regNo, email, mobileNo, age, address);

            messageLabel.Text = studentManager.DeleteStudent(student);

            ClearField();
        }

        protected void ClearField()
        {
            inputStudentName.Value=String.Empty;
            inputRegNo.Value=String.Empty;
            inputEmailAddress.Value=String.Empty;
            inputMobileNo.Value=String.Empty;
            inputAge.Value=String.Empty;
            inputAddess.Value=String.Empty;
        }

        
    }
}