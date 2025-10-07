using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Deleg(string text);
    class Delegate
    {

        public void Reen(string name)
        {
            Console.WriteLine($"This is the text:{name}");
        }
        public void Yeen(string Text)
        {
            Console.WriteLine("This is 2nd method "+ Text);
        }

    }
}
