using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Encapsulation
    {
        private int method;

        public void Change(int Method)
        {
            method = Method;
        }
        public void Print()
        {
            Console.WriteLine(method);
        }

    }
}
