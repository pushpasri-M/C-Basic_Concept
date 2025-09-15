using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Abstraction
    {
        public abstract void Rainy();
        public abstract void Sun();
        public void Sum()
        {
            Console.WriteLine("sum method");
        }
    }
    class Child1:Abstraction
    {
        public override void Rainy()
        {
            Console.WriteLine("this is overrided Abstract Class of method rainy");
        }
        public override void Sun()
        {
            Console.WriteLine("this is overrided Abstract Class of method sun");
        }
    }


}
