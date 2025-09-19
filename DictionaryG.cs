using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DictionaryG
    {
        public void DictionaryGen<TKey,TValue>(Dictionary<TKey,TValue> dict)
        {

            foreach (var entry in dict)
            {
                Console.WriteLine($"Key:{entry.Key}| Value:{entry.Value}");
            }

        }
    }
}
