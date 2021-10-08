using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Exception1
{
    class IndexOutOfBounds
    {
        static void Main(String[] args)
        {
            // declares an array of integers
            int[] anArray;
            anArray = new int[5];
            try
            {
                // initializing and printing the array
                for (int i = 0; i <= anArray.Length; i++)
                {
                    anArray[i] = i * 100;
                    Console.WriteLine(i);
                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }

            finally
            {
                Console.WriteLine(" Executing Finally code block !!");
            }

        }

    }
    }
