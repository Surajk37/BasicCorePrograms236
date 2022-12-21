using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class FlipCoin
    {
        /// <summary>
        /// Finding the percentage of Tails and Head.
        /// </summary>
        /// <param name="n"></param>
        public static void FindPercentage(int n)
        {
            int tailCount = 0,headCount=0;
            Random random = new Random();

            for(int i = 1; i <= n; i++)
            {
                double input = random.NextDouble();
                if(input < 0.5)
                    tailCount++;
                else
                    headCount++;
                Console.WriteLine("Random Values are:{0}",input);
            }
            Console.WriteLine("\nTail Count: {0}   Head Count: {1}",tailCount,headCount);

            double TailPercentage = (tailCount * 100) / n;
            double HeadPercentage = (headCount * 100) / n;
            Console.WriteLine("Percentage of Tails : {0}",TailPercentage);
            Console.WriteLine("Percentage of Head : {0}", HeadPercentage);
        }
    }
}
