using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", "LTP123", 1200.00, 1);
        Product product2 = new Product("Mouse", "MSE456", 25.00, 2);

        // Create an address
        Address address = new Address("123 Maple St", "Springfield", "IL", "USA");

        // Create a customer
        Customer customer = new Customer("Karina", address);

        // Create an order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display order info
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        

        // Create some products PART 2
        Product product3 = new Product("Fake Laptop", "NOTP12", 120.00, 1);
        Product product4 = new Product("Moose", "MSP456", 25.00, 2);

        // Create an address
        Address address2 = new Address("123 Maple St", "Springfield", "ID", "USA");

        // Create a customer
        Customer customer2 = new Customer("Karen", address2);

        // Create an order
        Order order2 = new Order(customer2);
        order.AddProduct(product3);
        order.AddProduct(product4);

        // Display order info
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}