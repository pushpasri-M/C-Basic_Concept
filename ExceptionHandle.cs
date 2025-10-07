using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExceptionHandle
    {
       public void Handle()
        {
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                int result = n / i;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant divide with zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("You cause error");//a try block program can use more then one catch
            }
            finally
            {
                Console.WriteLine("Thanks for Review");
            }
          
        }
    }


    
}