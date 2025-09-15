using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inheritance
    {
        public void run()
        {
            Console.WriteLine("hi..this is parent class");
        }

    }
    class A1 : Inheritance
    {
       public void Go()
        {
            Console.WriteLine("this is Base class");
        }
    }

    class A3 : Inheritance//heirachical inhertance
    {
        public void Go()
        {
            Console.WriteLine(" im also base class in heirachical ");
        }

    }
    class A2 : A1//multilevel inheritance
    {
        public void win()
        {
            Console.WriteLine(" This is base class1");
        }
    }
}
