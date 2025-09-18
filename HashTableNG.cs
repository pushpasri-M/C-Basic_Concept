using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HashTableNG
    {
        public void Hadtable()
        {
            Hashtable obj = new Hashtable();
            obj.Add(1, "hii");
            obj.Add(2, 'A');
            obj.Add("aa", 521);
            foreach(DictionaryEntry entry in obj)
            {
                Console.WriteLine($"Key:{entry.Key}| Value:{entry.Value}");
            }
        }
    }
}
