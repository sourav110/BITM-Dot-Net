using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Student : Person
    {
        public string Name { set; get; }
        public string RegNo { set; get; }
        public int Age { set; get; }

        public Address StudentAddress { set; get; }

        public double MathScore { set; get; }
        public double EngScore { set; get; }

        public string GetResult()
        {
            Calculator calculator = new Calculator();
            double totalScore = calculator.Add(MathScore, EngScore);
            double avgScore = calculator.Devide(totalScore, 2);

            if(avgScore >= 50)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
