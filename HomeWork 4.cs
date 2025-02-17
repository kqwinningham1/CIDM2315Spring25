namespace Homework4;

class Program
{
    static void Main(string[] args)
   // Call Q1_Method
    {
        int a = 3;
        int b = 5;

        int largest;

        if (a > b)
        {
            largest = a;
        }
        else
        {
            largest = b;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
    
    
    //Q1_Method
    
    /*{
       int a, b;

     
        Console.Write("Enter the first number: ");
        string num1 = Console.ReadLine();
        a = Convert.ToInt16(num1);  

        
        Console.Write("Enter the second number: ");
        string num2 = Console.ReadLine();
        b = Convert.ToInt16(num2);  

        int largest;

        if (a > b)
        {
            largest = a;
        }
        else
        {
            largest = b;
        }

        Console.WriteLine("The largest number is: " + largest);
    }*/
    


//Call Q2_Method
   
    /*{    int N = 5;

        
        Console.WriteLine($"N is: {N}; shape is left");

        
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }*/


//Q2_Method

    /*{    
        Console.Write("Enter the value of N: ");
        string input = Console.ReadLine(); 
        int N = Convert.ToInt16(input);  

        
        Console.WriteLine($"N is: {N}; shape is left");

        
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();  
        }
        
    }*/
}


