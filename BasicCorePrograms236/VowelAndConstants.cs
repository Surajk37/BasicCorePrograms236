using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms236
{
    public class VowelAndConstants
    {
        public void CheckTheTypeOfCharacter()
        {
            char ch;
            Console.WriteLine("Enter any Character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + "  - is  a Vowel. ");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {

            }
            else
            {
                Console.WriteLine(ch + "  - is not an vowel. ");
            }

        }
    }
}
