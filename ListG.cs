using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListG
    {
        public void ListOperate()
        {
            List<int> ls = new List<int>();
            ls.Add(2);
            ls.Add(767);
            ls.Add(45);
            ls.Remove(45);
            ls.RemoveAt(0);
            foreach(int i in ls){
                Console.WriteLine(i);
            }

        }
    }
}
