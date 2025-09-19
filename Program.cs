using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             
             //Inheritance
             //calling the method and content from Inheritance
             A2 Obj = new A2();
             Obj.win();
             Obj.Go();
             Obj.run();
             Console.ReadKey();

            //Interface
            //calling method by creating object in interface
            Bad obji1 = new character();
            good obji2 = new character();
            obji1.Goo();
            obji2.ROO();
            Console.ReadKey();
            
            //Encapsulation 
            Encapsulation obj= new Encapsulation();
            obj.Change(9);
            obj.Print();
            Console.ReadKey();
            

            //Abstraction
            Child1 obj = new Child1();
            obj.Sun();
            obj.Rainy();
            obj.Sum();
            Console.ReadKey();

            
            

            //Try Catch and Finally
            ExceptionHandle obj = new ExceptionHandle();
            obj.Handle();
            Console.ReadKey();
            
            
            //Custom Error handling
            Excuteion obj = new Excuteion();
            obj.implimentation();
            Console.ReadKey();
            

            //ArrayList(store different type of data to single object or ariable..comes under Collection)=> not stongly typed
            ArrayListe obj = new ArrayListe();
            obj.Addray();
            Console.ReadKey();
            

            //HashTable(Store the differnt type of data to dictionary... this dict can have any type of data type=> not strongly type)
            HashTableNG obj = new HashTableNG();
            obj.Hadtable();
            Console.ReadKey();
            

            //List in Generic
            ListG obj = new ListG();
            List<int> ls = new List<int>();
            ls.Add(2);
            ls.Add(767);
            ls.Add(45);
            ls.Remove(45);
            ls.RemoveAt(0);
            obj.rent<int>(ls);
            Console.ReadKey();
            


            //Dictionary
            DictionaryG ls = new DictionaryG();
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(1, "AAA");
            obj.Add(2, "BBB");
            obj.Add(3, "BBB");
            ls.DictionaryGen(obj);
            Console.ReadKey();

            

            //List in Generic
            ListG obj = new ListG();
            List<int> ls = new List<int>();
            ls.Add(2);
            ls.Add(767);
            ls.Add(45);
            ls.Remove(45);
            ls.RemoveAt(0);
            obj.rent<int>(ls);
            Console.ReadKey();
            

            // Lambda in C# syntax (parameter)=>expression_or_statement
            Func<int, int,int> gooo = (x, y) => x + y;                      //passing two argument with the return type of int
            Func<string> hoo = () => "Hellooo";                              // no parameter is passed and then has return type of string
            Action<string> roo =n => Console.WriteLine($"Hello {n}");         // for returning no data we should use the Action still we can get the parameter as shown in example
            Action yoo=()=>Console.WriteLine("hi");                        //if you want you can also pass no parameter and no return type using action
            Predicate<int> koo = n => n % 2 == 0;                            // predicate is used when we need the return type to be boolean
            Console.WriteLine(gooo(3, 8));
            Console.WriteLine(hoo());
            roo("sri");
            yoo();
            Console.WriteLine(koo(10));
            Console.ReadKey();

            */

            // LINQ topic
            List<genre> obj = new List<genre>
            {
                new genre{ Title="sroo", code=3334, place="india", rate=9.4},
                new genre{ Title="jroo", code=334, place="india", rate=9.0},
                new genre{ Title="iroo", code=333, place="US", rate=8.5},
                new genre{ Title="proo", code=3234, place="UK", rate=9.4},
                new genre{ Title="lroo", code=3354, place="US", rate=9.4}

            };
            //List<string> gameall = obj.Select(g => g.Title).ToList();
            //foreach(var n in gameall)
            //{
            //    Console.WriteLine(n);
            //}

            var gen = obj.Where(g => g.place == "india");
            foreach(var g in gen)
            {
                Console.WriteLine(g.Title);
            }
            Console.ReadLine();



        }
        }
}
