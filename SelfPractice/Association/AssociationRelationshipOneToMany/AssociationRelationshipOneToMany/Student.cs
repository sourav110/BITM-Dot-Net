using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipOneToMany
{
    class Student
    {
        public Student(string name, string regNo, string email)
        {
            Name = name;
            RegNo = regNo;
            Email = email;
        }

        public Student()
        {
        }

        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { set; get; }
    }
}
