﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Department : IBasicInfo, IPrintable
    {
        public string DeptName { get; set; }
        public string Code { get; set; }

        public string GetInfo()
        {
            return "Department GetInfo Method";
            //throw new NotImplementedException();
        }

        public void Print()
        {
            //throw new NotImplementedException();
        }

        public void PrintData()
        {
            //throw new NotImplementedException();
        }
    }
}
