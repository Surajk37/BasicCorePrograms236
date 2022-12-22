using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class HarmonicNumber
    {
        public static void CalHarmonicNumber()
        {
            //To Calculate sum of N^th harmonic number
            int a, i;
            double sum = 0;

            Console.WriteLine("Enter number of Terms to Add");
            a = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= a; i++)
            {
                Console.Write(" 1/{0} + ", i);
                sum = sum + 1.0 / i;
            }
            Console.WriteLine("\nSum of Harmonic Series of {0}  is : {1}", i, sum);
        }
    }
}

