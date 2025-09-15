using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomException : Exception
    {
       

    }
    class Excuteion
    {
        public void implimentation()
        {
            try
            {
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18)
                {
                    throw new CustomException();
                }
                else
                {
                    Console.WriteLine("you are Right");
                }
            }
            catch (CustomException)
            {
                Console.WriteLine("you should  increase the age >18");
            }
        }

    }
    
}
