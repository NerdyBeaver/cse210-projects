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