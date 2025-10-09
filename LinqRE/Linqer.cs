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
        new data {EmpID=24, depart="HR", Empname="ree", salary=55535},
        new data {EmpID=25, depart="R&D", Empname="rre", salary=5545},
        new data {EmpID=26, depart="R&D", Empname="rr", salary=5555},
        new data {EmpID=27, depart="HR", Empname="rreep", salary=5553}
        };
        public List<Department> de = new List<Department>
        {
            new Department{DepID=88,DepName="HR", Rating=5},
            new Department{ DepID=99, DepName="R&D", Rating=4}
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

        public void Sort()
        {
            var Sorted = ne.OrderBy(g => g.salary);
            foreach(var sr in Sorted)
            {
                Console.WriteLine(sr.Empname+"-----"+sr.salary);
            }
        }

        public void Compare()
        {
            var Comp = from emp in ne
                       join dep in de
                       on emp.depart equals dep.DepName
                       select new
                       {
                           EmployeeID = emp.EmpID,
                           EmployeeName = emp.Empname,
                           EmployeeSalary = emp.salary,
                           EmployeeDepartment = emp.depart,
                           EmployeeDepID = dep.DepID
                       };
            foreach(var re in Comp)
            {
                Console.WriteLine(re.EmployeeID + " " + re.EmployeeName + " " + re.EmployeeDepartment + " " + re.EmployeeDepID);
            }
        }
        
    }
}
