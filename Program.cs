using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp1.Search;
using ConsoleApp1.DataStructure;
using ConsoleApp1.sort;

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

            //var gen = obj.Where(g => g.place == "india");
            //foreach(var g in gen)
            //{
            //   Console.WriteLine(g.Title);
            //}

            int[] scores = { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            



            //File Handling-Create file
            string path = "sample.txt";
            File.WriteAllText(path, "Hello, this is a test file!");//done using write
            File.AppendAllText(path, "\n This is second line in the file");//append content
            Console.WriteLine(File.ReadAllText(path));//read the content of the file

            
            //this is done using the StreamWriter
            using (StreamWriter sw = new StreamWriter("Sass.txt"))//the file created using
            {
                sw.WriteLine("Line 1");
                sw.WriteLine("Line 2");

            }
            StreamReader sr = new StreamReader("Sass.txt");
            string line;
            while ((line = sr.ReadLine()) != null)  // read line by line
            {
                Console.WriteLine(line);
            }
            


            //Delegate 
            Delegate obj = new Delegate();
            //Delegate
            Deleg obj1 = new Deleg(obj.Reen);//Delegate refers to passing method as parameter 
            Deleg obj2 = new Deleg(obj.Yeen);//for accesing deleg the parameter and the return type should be same
            obj1.Invoke("string");
            obj2.Invoke("******");
            Deleg multiDeleg = obj1 + obj2;// Accessing more then one method with the help of delegate is called as Multicast Delecate....same parameter string is passed to the both delegte method at a time
            multiDeleg("uhsjhsh");
            Console.ReadLine();
            

           
            //Array
            Array rr = new Array();
            rr.AddArray();
            rr.AddFirst(9);
            Console.ReadKey();
            


            //Linear Search
            LinearSearch rr = new LinearSearch();
            Console.WriteLine(rr.Linear(3));
            Console.ReadKey();
            

            //Linked List
            LinkedListExample.LinkedLista ts = new LinkedListExample.LinkedLista();
            ts.ADD(33);
            ts.ADD(34);
            ts.ADD(36);
            ts.ADD(35);
            ts.Display();
            Console.ReadKey();
            


            //Stack
            Stack re = new Stack();
            Stack<int> orj = new Stack<int>();
            orj.Push(45);
            orj.Push(75);
            orj.Push(25);
            orj.Push(35);
            orj.Pop();

            re.Display<int>(orj);

            


            //Queue
            Queue queue = new Queue();
            Queue<int> vs = new Queue<int>();
            vs.Enqueue(4);
            vs.Enqueue(5);
            vs.Enqueue(6);
            vs.Enqueue(7);
            vs.Dequeue();
            queue.Display(vs);


            //Slection Sort
            Selection obj = new Selection();
            obj.SelectionSort();

            
            //Bubble Sort
            BubbleSort n = new BubbleSort();
            n.BubbleSor();


            */

            //Graph
            Graph graph = new Graph();
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);
            Console.WriteLine("Adjacency List of Graph:");
            graph.PrintGraph();


            Console.ReadKey();

        }
        }
}
