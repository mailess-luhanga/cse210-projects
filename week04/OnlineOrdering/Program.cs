using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA Customer)
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 50, 1));

        // Second Order (International Customer)
        Address address2 = new Address(
            "45 Great Road",
            "Lusaka",
            "Lusaka Province",
            "Zambia");

        Customer customer2 = new Customer("Mary Banda", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P200", 250, 2));
        order2.AddProduct(new Product("Headphones", "P201", 75, 1));

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n----------------------------\n");

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}