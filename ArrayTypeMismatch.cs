using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Exception1
{
    class ArrayTypeMismatch
    {
        
        static void Main(String[] args)
        {
            string[] anArray = new string[5];
            object[] objs=(object[]) anArray;
            try
            {
                objs[2] = (object)23;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
       
        
    }
}
