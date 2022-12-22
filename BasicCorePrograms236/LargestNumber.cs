using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class LargestNumber
    {
        public static void CheckLargestNumber()
        { 
            // To check largest number between 3 numbers
            int n1, n2, n3;
            Console.Write("Input the 1st Number : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2st Number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3st Number : ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nn1={0} \t n2={1} \t n3={2}",n1,n2,n3);
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("The 1st Number is gretest among three ");

                }
                else
                {
                    Console.WriteLine("The 3rd Number is gretest among three ");
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine("The 2nd Number is gretest among three ");
            }
            else
            {
                Console.WriteLine("The 3rd Number is gretest among three ");

            }

        }
    }
}
