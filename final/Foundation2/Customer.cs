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
