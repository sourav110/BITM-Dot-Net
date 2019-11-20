using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Course : IBasicInfo, IPrintable
    {
        public string CourseName { get; set; }
        public string Code { get; set; }

        public string GetInfo()
        {
            return "Course GetInfo Method";
            //throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Print Course Name: " + CourseName);
            //throw new NotImplementedException();
        }

        public void PrintData()
        {
            //throw new NotImplementedException();
        }
    }
}
