
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter your grade (A, B, C, D, F):");
            string grade = Console.ReadLine(); 
            Console.WriteLine(grade);

            if (grade=="A"){
                Console.WriteLine("GPA 4");
            }
            else if (grade=="B"){
                Console.WriteLine("GPA 3");
            }
            else if(grade=="C"){
                Console.WriteLine("GPA 2");
            }
            else if(grade=="D"){
                Console.WriteLine("GPA 1");
            }
            else if(grade=="F"){
                Console.WriteLine("GPA 0");
            }
            
            else{
                Console.WriteLine("Wrong letter grade");
            }
            
            
            
        }
    }
}