using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Ascyn_Thread
{
    public class Asychronous
    {
        public void Example()
        {
           Thread t=new Thread(()=> {
               for(int i=0;i<10;i++)
               {
                   Console.WriteLine("Thread "+i);
                   Thread.Sleep(1000);
               }
           });
              t.Start();
              for(int i=0;i<10;i++)
                {
                    Console.WriteLine("Main "+i);
                    Thread.Sleep(500);
            }
        }

        public async Task<int> GetDataAsyn()
        {
            await Task.Delay(50); 
            // Simulate a delay of 5 seconds
            return 42; // Return some data after the delay
        }
    }
}
