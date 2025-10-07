using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayListe
    {
        public void Addray()
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("say");
            obj.Add('d');
            obj.Add(2.3);
            int[] ac = { 2, 3, 4 };
            string[] bs = { "sdd", "assa", "yuiu" };
            obj.AddRange(ac);
            obj.AddRange(bs);
            foreach(var ob in obj)
            {
                Console.WriteLine(ob);
            }
        }

        
    }
}
