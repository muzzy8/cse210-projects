
public class Order
{
    // Attributes
    private Customer _customer;
    private List <Product> _products = new List<Product>();

    // Constructors
    public Order()
    {

    }

    // Methods
    public double CalculateTotalCost()
    { // The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        double productSubtotal = 0.0;
        double shippingCost = 0.0;
        double orderTotalCost = 0.0;

        foreach (Product product in _products)
        {
            productSubtotal += product.CalculateTotalPrice();
        }

        if (_customer.GetIsDomestic() == true)
        {
            shippingCost = 5.00;
        }
        else if (_customer.GetIsDomestic() == false)
        {
            shippingCost = 35.00;
        }

        orderTotalCost = productSubtotal + shippingCost;

        return orderTotalCost;
    }

    public void AddProduct(string name, string productId, double pricePerUnit, int quantity)
    {
        Product newProduct = new Product(name, productId, pricePerUnit, quantity);
        _products.Add(newProduct);
    }
    
    public string CreatePackingLabel()
    { // A packing label should list the name and product id of each product in the order.
        string packingLabel = "CONTENTS:\n";
        int number = 0;
        
        foreach (Product product in _products)
        {
            number += 1;
            packingLabel += $"{product.GetProductId()}     {number}.  {product.GetName()}\n             x{product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    { // A shipping label should list the name and address of the customer
        string shippingLabel = $"SHIP TO:\n{_customer.GetName()}\n{_customer.RetrieveFullAddress()}\n";
        return shippingLabel;
    }

    public void MakeCustomer(string name, string streetAddress, string city, string stateProvince, string country)
    {
        Address customerAddress = new Address(streetAddress, city, stateProvince, country);
        _customer = new Customer(name, customerAddress);
    }

    public void MakeAddress(string streetAddress, string city, string stateProvince, string country)
    {
        Address newAddress = new Address(streetAddress, city, stateProvince, country);
    }

}