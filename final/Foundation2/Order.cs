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
