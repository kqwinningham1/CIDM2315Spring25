namespace Homework8;




//Q1 Method and answer




/*        class Customer
{   public string CustomerName { get; }
    public int CustomerAge { get; }
    public string CustomerCity { get; }
    public double CustomerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        TotalCredits(customer_list);
    }

    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;

        foreach (Customer customer in customer_list)
        {
            totalCredit += customer.CustomerCredit;
        }

        Console.WriteLine("Total Credit of All Customers: " + totalCredit);
    }

    }*/





//Q2 method and answer




/*using System;

class Customer
{
    public string CustomerName { get; }
    public int CustomerAge { get; }
    public string CustomerCity { get; }
    public double CustomerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer[] customer_list =
        {
            new Customer("Alice", 33, "Amarillo", 198.5),
            new Customer("Bob", 23, "Amarillo", 226),
            new Customer("Cathy", 45, "Amarillo", 89.0),
            new Customer("David", 58, "Amarillo", 198.5),
            new Customer("Jack", 28, "Canyon", 561.6),
            new Customer("Tom", 36, "Canyon", 98.4),
            new Customer("Tony", 24, "Canyon", 18.5),
            new Customer("Sam", 35, "Canyon", 228.3)
        };

        AverageAgeAmarillo(customer_list);
    }

   public static void AverageAgeAmarillo(Customer[] customer_list)
{
    if (customer_list == null || customer_list.Length == 0)
    {
        Console.WriteLine("Customer list is empty or null.");
        return;
    }

    int totalAge = 0;
    int count = 0;

    foreach (Customer customer in customer_list)
    {
        if (customer.CustomerCity == "Amarillo") // Exact match (case-sensitive)
        {
            totalAge += customer.CustomerAge;
            count++;
        }
    }

    if (count > 0)
    {
        Console.WriteLine("Average Age of Customers in Amarillo: " + ((double)totalAge / count));
    }
    else
    {
        Console.WriteLine("No customers found in Amarillo.");
    }
}
}*/




//Q3 method and answer



/*using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        PrintCanyonCustomersOver30(customer_list);
    }

    static void PrintCanyonCustomersOver30(Customer[] customers)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].City == "Canyon" && customers[i].Age > 30)
            {
                Console.WriteLine(customers[i].Name);
            }
        }
    }
}

class Customer
{
    public string Name { get; }
    public int Age { get; }
    public string City { get; }
    public double Credit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        Name = customerName;
        Age = customerAge;
        City = customerCity;
        Credit = customerCredit;
    }
}*/




