using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataStructure
{
    class Stack
    {
        
        public void Display<T>(Stack<T> obj)
        {
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
