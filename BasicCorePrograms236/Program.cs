namespace BasicCorePrograms236
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Welcome To Basic Core Programs\n");

            Console.WriteLine("Please choose a option from Below List");
            Console.WriteLine("1. FlipCoin \n2. Leapyear \n3. PowerOf2 \n4. HarmonicNumber \n5. Factors");
            Console.WriteLine("6. QuotientandRemainder \n7. SwapTwoNumbers \n8.EvenOrOdd");
            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.WriteLine("\tFlip Coin Program");
                    Console.WriteLine("Enter a Number of Time to Flip the Coin");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.FindPercentage(n);
                    break;

                    case 2:
                    Console.WriteLine("\tLeap Year Program");
                    LeapYear.ToCheckYear(); 
                    break;

                case 3:
                    Console.WriteLine("\n\tPower of 2 Program");
                    Console.WriteLine("Enter a Number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    PowerOf2 p = new PowerOf2();
                    p.CalculatePower(num);
                    break;

                case 4:
                    Console.WriteLine("\n\tHarmonic Number Program");
                    HarmonicNumber.CalHarmonicNumber();
                    break;

                case 5:
                    Console.WriteLine("\n\tFactors Program");
                    Factors fact = new Factors();
                    fact.FactorOfNumber();
                    break;

                case 6:
                    Console.WriteLine("\n\tQuotient And Remainder Program\n");
                    Console.WriteLine("Enter Dividend");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Dividend");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    QuotientandRemainder.checkQuotientRemainder(dividend,divisor);
                    break;

                case 7:
                    Console.WriteLine("\n\tSwapping Two Numbers Program");
                    SwapTwoNumbers.SwappingNumber();
                    break;

                case 8:
                    Console.WriteLine("\n\tEven Or Odd Program");
                    EvenOrOdd.CheckEvenOdd();
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}