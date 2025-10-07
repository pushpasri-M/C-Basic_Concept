using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataStructure
{
    class Queue
    {
        public void Display<T>(Queue<T> que)
        {
            foreach(var i in que)
            {
                Console.WriteLine(i);
            }
        }
    }
}
