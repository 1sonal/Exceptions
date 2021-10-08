using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Exception1
{
    class NullReference
    {
       
        
        static void Main(String[] args)
        {
            String string1=null;

            try
            {
                Console.WriteLine(string1.Substring(4));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
