namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1; 
            }
            else
            {
                smallest = num3; 
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2; 
            }
            else
            {
                smallest = num3; 
            }
        }

        Console.WriteLine($"The smallest number is: {smallest}");
    }
}

