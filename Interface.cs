using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IBad
    {
        void Goo();
       
    }
    interface Igood
    {
        void ROO();

    }

    class character : IBad,Igood
    {
        public void Goo()
        {
            Console.WriteLine("gooo home");
        }
        public void ROO()
        {
            Console.WriteLine("Heyyyy...");
        }
    }
}
