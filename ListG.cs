using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListG
    {
        public void rent<T>(List<T> numbers)
        {
            foreach(var i in numbers){
                Console.WriteLine(i);
            }

        }
    }
}
