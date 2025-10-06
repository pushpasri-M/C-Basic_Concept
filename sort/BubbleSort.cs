using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.sort
{
    class BubbleSort
    {
        public void BubbleSor()
        {
            int[] n = { 7, 5, 6, 1, 2, 3, 9 };
            int temp;
            for (int i = 0; i < n.Length; i++)
            {
                
                for (int j = 0; j < (n.Length)-1; j++)
                {
                    if (n[j] > n[j+1])
                    {
                        temp = n[j];
                        n[j] = n[j+1];
                        n[j+1] = temp;
                    }
                }
            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
