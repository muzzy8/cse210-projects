public class Product
{
    // Attributes
    public string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor
    public Product()
    {

    }
    
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Methods
    public double CalculateTotalPrice()
    {
        double productTotalPrice = _pricePerUnit * _quantity;
        return productTotalPrice;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

}