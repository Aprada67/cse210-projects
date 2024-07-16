using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer costumer)
    {
        _products = products;
        _customer = costumer;
    }

    public Order() { }

    // Getters and Setters
    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    // Functionality
    public double CalculateSubtotal()
    {
        double subtotal = 0;

        foreach(Product product in _products)
        {
            double productPrice = product.GetPrice();
            subtotal += productPrice;
        }
        subtotal = Math.Round(subtotal, 2);
        return subtotal;
    }

    public double CalculateTotal()
    {
        Customer customer = new Customer();

        double subtotal = CalculateSubtotal();
        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
       return string.Join("\n", _products.Select(p => $"{p.GetName()} (ID: {p.GetId()}) Quantity: {p.GetQuantity()}"));
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetStreet()}, {_customer.GetAddress().GetCity()}, {_customer.GetAddress().GetProvince()}, {_customer.GetAddress().GetCountry()}";
    }
}