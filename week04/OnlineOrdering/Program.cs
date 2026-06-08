using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
=======
        // Order 1 (USA Customer)
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

<<<<<<< HEAD
        Customer customer1 = new Customer(
            "John Smith",
            address1);
=======
        Customer customer1 = new Customer("John Smith", address1);
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Mouse", "P102", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 50, 1));

<<<<<<< HEAD
        Address address2 = new Address(
            "45 King Road",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Sarah Johnson",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P201", 200, 2));
        order2.AddProduct(new Product("Webcam", "P202", 75, 1));

        Console.WriteLine("===== ORDER 1 =====");

        Console.WriteLine("\nShipping Label:");
=======
        // Order 2 (International Customer)
        Address address2 = new Address(
            "45 Great East Road",
            "Lusaka",
            "Lusaka",
            "Zambia");

        Customer customer2 = new Customer("Mary Banda", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P201", 500, 1));
        order2.AddProduct(new Product("Headphones", "P202", 75, 2));

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Shipping Label:");
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

<<<<<<< HEAD
        Console.WriteLine("\n===== ORDER 2 =====");

        Console.WriteLine("\nShipping Label:");
=======
        Console.WriteLine("\n-------------------------\n");

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("Shipping Label:");
>>>>>>> c840579d2db24b63061d3bf3f6bbad7c90f4f6d1
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}