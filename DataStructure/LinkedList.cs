using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataStructure
{
    class LinkedListExample
    {
        public class Node
        {
            public int Data;    // stores data
            public Node Next;   // reference to next node

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedLista{
            private Node head;
            public void ADD(int data)
            {
                Node r = new Node(data);
                if (head == null)
                {
                    head = r;
                    return;
                }
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next=r;
                
            }


            public void Display()
            {
                if (head == null)  // check before using
                {
                    Console.WriteLine("List is empty!");
                    return;
                }
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data+"->");
                    current = current.Next;
                }
                Console.WriteLine("/END");
            }


        }


    }
}
