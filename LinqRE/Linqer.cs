using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinqRE
{
    public class Linqer
    {
        public List<data> ne = new List<data> {
        new data {EmpID=23, depart="HR", Empname="rree", salary=5553},
        new data {EmpID=23, depart="HR", Empname="ree", salary=55535},
        new data {EmpID=23, depart="R&D", Empname="rre", salary=5545},
        new data {EmpID=23, depart="R&D", Empname="rr", salary=5555},
        new data {EmpID=23, depart="HR", Empname="rreep", salary=5553}
        };

        public void Selecte()
        {
            var SelectedData = ne.FindAll(g => g.depart == "HR");
            foreach (var selected in SelectedData)
            {
                Console.WriteLine(selected.Empname);
            }
        }


        public void grouping()
        {
            var grouped = ne.GroupBy(g => g.depart);
            foreach(var num in grouped)
            {
                Console.WriteLine($"{num.Key}......");
                foreach(var value in num)
                {
                    Console.WriteLine(value.salary);
                }
            }
        }

        public void Aggregate()
        {
            var max_saal = ne.Max(g => g.salary);
            Console.WriteLine("\n"+max_saal);
        }

        
    }
}
