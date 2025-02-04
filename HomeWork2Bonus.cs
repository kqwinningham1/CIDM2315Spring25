
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
         {
        // Bonus question code
         Console.Write("Enter a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
        }
    }
}