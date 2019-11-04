using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Department
    {
        public string DeptName { set; get; }
        public int DeptCode { set; get; }

        public List<Student> Students { set; get; }

        public Department()
        {
            Students = new List<Student>();
        }
    }
}
