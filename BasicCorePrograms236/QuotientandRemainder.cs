using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class QuotientandRemainder
    {
        public static void checkQuotientRemainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend: {0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Qotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
