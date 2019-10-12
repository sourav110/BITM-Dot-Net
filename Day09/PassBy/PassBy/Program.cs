using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBy
{
    class Program
    {
        static void Main(string[] args)
        {
            //----Pass by Value
            //int num1 = 5;
            //int num2 = 10;

            //Console.WriteLine(num1 + " " + num2);
            //Square(num1, num2);
            //Console.WriteLine(num1 + " " + num2);
            //Console.ReadLine();

            //----Pass by Reference

            Person p1 = new Person();
            Person p2 = new Person();

            p1.age = 5;
            p2.age = 10;

            Console.WriteLine(p1.age + " " + p2.age);
            Square(p1, p2);
            Console.WriteLine(p1.age + " " + p2.age);
            Console.ReadLine();

            Console.ReadKey();
        }

        static void Square(int a, int b)

        {

            a = a * a;

            b = b * b;

            Console.WriteLine(a + " " + b);

        }

        static void Square(Person a, Person b)

        {

            a.age = a.age * a.age;

            b.age = b.age * b.age;

            Console.WriteLine(a.age + " " + b.age);

        }
    }
}
