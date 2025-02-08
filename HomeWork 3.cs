/*namespace HomeWork3;
class Program
{
    static void Main(string[]args)
    {
     //Code for Q1
        Console.WriteLine("Input an integer:");
        int num = Convert.ToInt16(Console.ReadLine());

        if(num <=1)
        {
                Console.WriteLine("N is prime");

        }
        else
        {
                for (int n =2; n < num; n++)
                {
                    if (num % n ==0)
                    {
                        Console.WriteLine("N is non-prime");
                        return;
                    }
                }
                Console.WriteLine("N is prime");
        }
 }
{  //Code for Q2
        Console.WriteLine("Assign an int value to N:");
            int N = Convert.ToInt16(Console.ReadLine()); 

            
            for (int row = 0; row < N; row++)
            {
                
                for (int col = 0; col < N; col++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();}
    }
 { 
    // Code for Q3
            Console.WriteLine("Assign an int value to N:");
            int N = Convert.ToInt16(Console.ReadLine()); 


            for (int row = 1; row <= N; row++)
            {
                
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
    }
{    //Code for Bonus
            Console.WriteLine("Assign an int value to N:");
            int N = Convert.ToInt16(Console.ReadLine()); 

            
            for (int row = 1; row <= N; row++)
            {
                
                for (int space = 0; space < N - row; space++)
                {
                    Console.Write(" "); 
                }

                
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(row); 
                }

                Console.WriteLine();
            }
    }
}