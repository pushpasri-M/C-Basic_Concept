using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.sort
{
    class Selection
    {
        /// <summary>
        /// Selection Sort....get 1 index value and compare to the value in the Array ans swap them to Achive Sorting
        /// </summary>
        public void SelectionSort()
        {
            int[] n = { 7,5,6,1,2,3,9};
            int temp;
            for(int i = 0; i < n.Length; i++)
            {
                int max_index = i;
                for(int j = 0; j < n.Length; j++)
                {
                    if (n[j] > n[max_index])
                    {
                        temp = n[j];
                        n[j] = n[max_index];
                        n[max_index] = temp;
                    }
                }
            }
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
