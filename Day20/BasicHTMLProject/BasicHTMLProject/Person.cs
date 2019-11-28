﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicHTMLProject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string  LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}