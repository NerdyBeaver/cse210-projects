using System;

using System;
using System.Collections.Generic;

public class Program2
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1_1 = new Product("Laptop", "LAP101", 1200.00, 1);
        Product product1_2 = new Product("Mouse", "MOU202", 25.00, 2);
        order1.AddProduct(product1_1);
        order1.AddProduct(product1_2);

        Console.WriteLine("--- Order 1 Details ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine("------------------------\n");

        // --- Order 2: International Customer ---
        Address address2 = new Address("45 Rue de la Paix", "Paris", "Ile-de-France", "France");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product2_1 = new Product("Keyboard", "KEY303", 75.00, 1);
        Product product2_2 = new Product("Headphones", "HP404", 150.00, 1);
        Product product2_3 = new Product("USB Drive", "USB505", 10.00, 5);
        order2.AddProduct(product2_1);
        order2.AddProduct(product2_2);
        order2.AddProduct(product2_3);

        Console.WriteLine("--- Order 2 Details ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():0.00}");
        Console.WriteLine("------------------------\n");
    }
}