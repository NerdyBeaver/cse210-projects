using System;

using System;
using System.Collections.Generic;

public class Address
{
    // Private attributes for the address components
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize address components
    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return the full address as a formatted string
    public string GetFullAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}

public class Customer
{
    // Private attributes for customer name and address
    private string _customerName;
    private Address _customerAddress; // Address is a class instance

    // Constructor to initialize customer name and address
    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // Method to return the customer's name
    public string GetCustomerName()
    {
        return _customerName;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA(); // Delegates to the Address class
    }

    // Method to get the customer's address as a formatted string
    public string GetCustomerAddressString()
    {
        return _customerAddress.GetFullAddressString(); // Delegates to the Address class
    }
}

public class Product
{
    // Private attributes for product details
    private string _productName;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor to initialize product details
    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    // Method to calculate the total cost for this product (price * quantity)
    public double GetProductTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Method to get the product name
    public string GetProductName()
    {
        return _productName;
    }

    // Method to get the product ID
    public string GetProductId()
    {
        return _productId;
    }
}

public class Order
{
    // Private attributes for the list of products and the customer
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order, including shipping
    public double CalculateTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetProductTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00; // Conditional shipping cost

        return totalProductCost + shippingCost;
    }

    // Method to get the packing label string
    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to get the shipping label string
    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"Customer: {_customer.GetCustomerName()}\n";
        label += _customer.GetCustomerAddressString(); // Uses the customer's address string
        return label;
    }
}

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