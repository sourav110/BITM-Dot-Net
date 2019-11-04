using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UVManagementSystemApp.Models;
using UVManagementSystemApp.DAL;
using System.Drawing;
using UVManagementSystemApp;


namespace UVManagementSystemApp.BLL
{
    class StudentManager
    {
        private StudentGateway studentGateway = new StudentGateway();

        public string SaveStudent(Student student)
        {
            if (studentGateway.IsRegNoExist(student.RegNo))
            {
                return "Already Exists";
            }

            int rowEffect = studentGateway.SaveStudent(student);

            if (rowEffect > 0)
            {
                return "Successfully Saved.";
            }

            return "Failed to Save.";
        }

        public List<Student> GetAllStudents()
        {
            return studentGateway.GetAllStudentsFromDB();
        }
    }
}
