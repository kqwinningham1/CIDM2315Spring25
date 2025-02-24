namespace Homework5;

class Program
{
    static void Main(string[] args)
    /*{
        // Call Q1_Method

        int largestNumber = Q1_Method();
        Console.WriteLine("The largest number is: " + largestNumber);
    }
    
    // Q1 Method

    static int Q1_Method()
    {
        int a, b;

        Console.Write("Enter the first number: ");
        a = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = Convert.ToInt16(Console.ReadLine());

        int largest = (a > b) ? a : b;

        return largest;
    }*/
    
    /*{
    // Call Q2_Method

        int largestNumber = Q2_Method();
        
        Console.WriteLine("The largest number is: " + largestNumber);
    }

    static int Q1_Method(int a, int b)
    {
        return (a > b) ? a : b;
    }

    //Q2_Method

    static int Q2_Method()
    
    {
        int a, b, c, d;

        Console.Write("Enter the first number: ");
        a = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the third number: ");
        c = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        d = Convert.ToInt16(Console.ReadLine());

        int max1 = Q1_Method(a, b);

        int max2 = Q1_Method(c, d);

        return Q1_Method(max1, max2);

    }*/

    /*{
    //Q3_Method
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year; 
        int age = currentYear - birth_year;  
        return age >= 18; 
    }

    static void createAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine(); 
        Console.Write("Enter password: ");
        string password = Console.ReadLine(); 

        Console.Write("Re-enter password: ");
        string confirmPassword = Console.ReadLine(); 
        Console.Write("Enter your birth year: ");
        int birthYear = Convert.ToInt16(Console.ReadLine()); 

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully.");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }*/


}
