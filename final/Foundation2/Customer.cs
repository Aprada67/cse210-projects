public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer() { }

    // Getters and Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        if (_address == null)
        {
            return false;
        }
        return _address.IsInUSA();
    }
}