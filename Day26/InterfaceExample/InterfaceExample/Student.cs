using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Student : IBasicInfo, ISaveInfo
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }

        public string GetInfo()
        {
            return Name + "'s (Student) GetInfo Method";
            //throw new NotImplementedException();
        }

        public string SaveInfo()
        {
            return Name + "'s info saved successfully";
            throw new NotImplementedException();
        }
    }
}
