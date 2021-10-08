using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Exception1
{
    class ExceptionHandling
    {
        private static void divide(int num1,int num2)
        {
            if ((num1 < 0) || (num2 < 0))
                throw new NegativeNumberException("Negative numbers are not allowed");  // user defined exceptions
            int num3 = num1 / num2;
            Console.WriteLine("result of division is={0}" ,num3);
        }
        static void Main(String[] args)
        {
            try
            {
                divide(-23, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero not possible ,corrected to one");
                divide(23, 1);
            }
            catch(NegativeNumberException ee)
            {
                 Console.WriteLine("User defined exception: {0}", ee.Message);
              //  Console.WriteLine("Negative numbers not allowed");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
       
            
        
    }
}
