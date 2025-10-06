using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Search
{
    class LinearSearch
    {
        int[] arr = { 6, 9, 0, 8, 5, 3, 1, 2 };
        public bool Linear(int num)
        {
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
