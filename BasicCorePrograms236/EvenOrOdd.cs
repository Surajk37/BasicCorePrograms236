using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class EvenOrOdd
    {
        public static void CheckEvenOdd()
        {
            int a;
            Console.WriteLine("Enter a Range to check even or odd");
            a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number", i);
                }
                else if(i % 2 == 1)
                {
                    Console.WriteLine("{0} is Odd Number", i);
                }
            }
           
        }
    }
}
