using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class PowerOf2
    {
        public  int CalculatePower(int num)
        {
            Console.WriteLine("Power of 2^ " + num + " is : " + (Math.Pow(2, num))+"\n");

            Console.WriteLine("\nPrinting all till power value : " + num);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Power of 2^ " + i + " : " + (Math.Pow(2, i)));
            }
            return num;
        }
    }
}
