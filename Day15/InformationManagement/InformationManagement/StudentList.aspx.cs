using InformationManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InformationManagement.BLL;

namespace InformationManagement
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllStudentInfo();
        }

        private void ShowAllStudentInfo()
        {
            StudentManager studentManager = new StudentManager();

            StudentGrirdView.DataSource = studentManager.GetALLStudents();
            StudentGrirdView.DataBind();

        }
    }
}