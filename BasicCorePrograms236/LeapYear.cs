using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    internal class LeapYear
    {
        public static void ToCheckYear()
        {
            //Checking year is leap or not

            int year;
            Console.WriteLine("Enter Four Digit Year Value");
            year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1000 && year <= 9999)
            {
                if ((year % 4 == 0) && (year % 100 !=0) )
                    Console.WriteLine("Leap year");
                else
                    Console.WriteLine("Not a Leap year");
            }
            else
            {
                Console.WriteLine("Please Enter valid Year Value");
            }
        }
    }
}
