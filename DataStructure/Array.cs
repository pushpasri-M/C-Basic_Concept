using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {
        /// <summary>
        /// Add Array value to the end of the array
        /// </summary>
        public void AddArray()
        {
            int[] arr = new int[6];
            int length = 0;
            for(int i = 0; i < 3; i++)
            {
                arr[length] = i+1;
                length++;
            }
            arr[length] = 8;
            for(int i = 0; i <= length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        /// <summary>
        /// Add value to the Start of the Array
        /// </summary>

        public void AddFirst(int num)
        {
            int temp;
            int[] arr = new int[6];
            int length = 0;
            for (int i = 0; i < 3; i++)
            {
                arr[length] = i + 1;
                length++;
            }
            
            for (int i = 0; i <=length; i++)
            {
                temp = arr[0+i];
                arr[0+i] = num;
                num = temp;
            }
            for(int i = 0; i <= length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        

    }
}
