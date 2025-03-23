namespace Homework7;
using System;

class Customer
{
    //Q1
    private int cus_id;
    public string cus_name { get; set; }
    public int cus_age { get; set; }

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("Both customers are of the same age.");
        }
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);
        
        Console.WriteLine("Initial Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        
        customer1.ChangeID(220);
        customer2.ChangeID(221);
        
        Console.WriteLine("\nUpdated Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        
        Console.WriteLine();
        customer1.CompareAge(customer2);
    }
}












/*
//Q2
using System;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Customer(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {Id}, Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);
        
        Console.WriteLine("Initial Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        
        customer1.Id = 220;
        customer2.Id = 221;
        
        Console.WriteLine("\nUpdated Customer Information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();
        
        if (customer1.Age > customer2.Age)
        {
            Console.WriteLine($"\n{customer1.Name} is older.");
        }
        else if (customer2.Age > customer1.Age)
        {
            Console.WriteLine($"\n{customer2.Name} is older.");
        }
        else
        {
            Console.WriteLine("\nBoth customers are of the same age.");
        }
    }
}
*/

