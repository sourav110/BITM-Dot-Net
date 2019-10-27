using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.DAL;
using InformationManagement.Models;


namespace InformationManagement.BLL
{
    public class StudentManager
    {
        public string SaveStudent(Student student)
        {
            StudentGateway studentGateway = new StudentGateway();

            bool isExisted = studentGateway.ExistStudent(student);

            if (isExisted)
            {
                return "Already Exits";
            }

            else
            {
                bool isSaved = studentGateway.SaveStudent(student);

                if (isSaved)
                {
                    return "Student saved Successfully";
                }
                else
                {
                    return "Failed to save!";
                }
            }
            
        }

        public List<Student> GetALLStudents()
        {
            StudentGateway studentGateway = new StudentGateway();

            return studentGateway.GetAllStudents();
        }

        public string UpdateStudent(Student student)
        {
            StudentGateway studentGateway = new StudentGateway();
            bool isExisted = studentGateway.ExistStudent(student);

            if (isExisted)
            {
                bool isUpdated = studentGateway.UpdateStudent(student);

                if (isUpdated)
                {
                    return "Update Successfull";
                }
                else
                {
                    return "Failed to Update";
                }
            }

            else
            {
                return "Student doesn't exist!";
            }
        }

        public string DeleteStudent(Student student)
        {
            StudentGateway studentGateway = new StudentGateway();
            bool isExisted = studentGateway.ExistStudent(student);

            if (isExisted)
            {
                bool isDeleted = studentGateway.DeleteStudent(student);

                if (isDeleted)
                {
                    return "Delete Successfull";
                }
                else
                {
                    return "Failed to Delete";
                }
            }

            else
            {
                return "Student doesn't exist!";
            }
        }
    }
}