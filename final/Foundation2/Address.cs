public class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private string _fullAddress;

    // Constructors
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Methods
    public bool CheckIfDomestic()
    {
        bool isDomestic = true; 
        if (_country != "USA")
        {
            isDomestic = false;
        }
    
        return isDomestic;
    }

    private void CompressFullAddress()
    { // setter
        string compressedAddress = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        _fullAddress = compressedAddress;
    }

    public string GetFullAddress()
    { // getter
        CompressFullAddress();
        return _fullAddress;
    }
}