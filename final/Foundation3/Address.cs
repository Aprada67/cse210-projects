public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _zipCode;
    private string _country;

    public Address(string street, string city, string province, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _zipCode = zipCode;
        _country = country;
    }

    public Address()
    {

    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_province}, {_zipCode}, {_country}";
    }
}