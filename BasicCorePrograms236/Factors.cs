using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal  class Factors
    {
        public void FactorOfNumber()
        {
            //Program to get a Prime factors of a number 
            int num;
            int count = 0;
            int flag = 0;
            Console.Write("Enter a Number for prime factor : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Prime Factors of {0} are ", num);
            for (int i = 1; i <= num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {

                    Console.WriteLine(i + ",");
                }

                // check for prime number
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                {
                    flag = 1;
                    Console.Write(i + " ");
                }
            }
            //if (flag == 0)
            //Console.Write("There is no Prime factor for {0} ", num);
        }        
    }
}
