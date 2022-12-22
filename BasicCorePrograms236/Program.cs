namespace BasicCorePrograms236
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Welcome To Basic Core Programs\n");

            Console.WriteLine("Please choose a option from Below List");
            Console.WriteLine("1. FlipCoin \n2.Leapyear");
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
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}