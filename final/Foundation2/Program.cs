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
    }
}