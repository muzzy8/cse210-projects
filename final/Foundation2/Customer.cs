public class Customer
{
    // Attributes
    private string _name;
    private Address _address;
    private bool _isDomestic;

    // Constructors
    public Customer()
    {

    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public string GetName()
    {
        return _name;
    }
    public void SetIsDomestic()
    {
        _isDomestic = _address.CheckIfDomestic();
    }
    public bool GetIsDomestic()
    {
        SetIsDomestic();
        return _isDomestic;
    }

    public string RetrieveFullAddress()
    {
        return _address.GetFullAddress();
    }

}