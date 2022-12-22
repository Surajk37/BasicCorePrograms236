using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class SwapTwoNumbers
    {
        public static int SwappingNumber()
        { 
            //Swap the two numbers . 

            Console.WriteLine("Enter First Value");
            int  a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a = " + a + "  b = " + b);

            a = a * b;  //a=50(5*10)
            b = a / b;  //b=5(50/10)
            a = a / b;  //a=10(50/5)

            Console.WriteLine("After Swapping  a = " + a + "  b = " + b);
            return 0;
        }
    }
}
