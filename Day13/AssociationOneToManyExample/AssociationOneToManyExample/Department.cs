using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToManyExample
{
    class Department
    {

        public string Name { set; get; }
        public string Location { set; get; }
        public string Code { set; get; }

        public List<Student> Students { set; get; }

        //public List<Student> Students       //this Students is refference 
        //Students = new List<Student>();     //this Students is object

        public Department()
        {
            Students = new List<Student>(); 
        }

        public Department(string name, string location, string code): this()
        {
            Name = name;
            Location = location;
            Code = code;
        }

        public string AddStudent(Student aStudent)
        {
            if(StudentNotFound(aStudent.RegNo))
            {
                Add(aStudent);
                return "Student info added";
            }
            else
            {
                return "Student already exists";
            }
        }

        private bool StudentNotFound(string regNo)
        {
            foreach(Student aStudent in Students)
            {
                if(aStudent.RegNo == regNo)
                {
                    return false;
                }
            }

            return true;
        }

        private void Add(Student aStudent)
        {
            Students.Add(aStudent);
        }

    }
}
