using System.Data.Common;

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public Product() { }

    // Getters and Setters

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetId(string id)
    {
        _id = id;
    }

    public string GetId()
    {
        return _id;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Functionality
    public double TotalCost()
    {
        return _price * _quantity;
    }

}