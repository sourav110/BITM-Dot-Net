using System;
using System.Collections.Generic;

namespace AssociationRelationshipOneToMany
{
    class Department
    {
        public Department(string name, string location, string code):this()
        {
            Name = name;
            Location = location;
            Code = code;
        }

        public Department()
        {
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
        public List<Student> Students { set; get; }

        public string AddStudent(Student aStudent)
        {
            if (StudentNotFound(aStudent.RegNo))
            {
                Add(aStudent);
                return "Added";
            }
            else
            {
                return "Already exists";
            }
        }

        private bool StudentNotFound(string regNo)
        {
            foreach (Student aStudent in Students)
            {
                if (aStudent.RegNo == regNo)
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
