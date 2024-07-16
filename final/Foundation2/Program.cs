using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("828 Broadway", "New York", "NY", "USA");
        Address address2 = new Address("Av. Principal Lomas de Funval", "Valencia", "Carabobo", "Venezuela");

        Customer customer1 = new Customer("James Smith", address1);
        Customer customer2 = new Customer("Alberto Prada", address2);

        Product product1 = new Product("Iphone 15 Pro Max", "Iphone2024", 1400.99, 1);
        Product product2 = new Product("Macbook Air", "Macbook2021", 950.54, 2);
        Product product3 = new Product("Airpods", "Airpods2022", 399.99, 1);

        Order order1 = new Order(new List<Product> { product1, product3}, customer1);
        Order order2 = new Order(new List<Product> { product1, product2, product3}, customer2);

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: {order1.CalculateTotal()}$\n");

        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: {order2.CalculateTotal()}$");
    }
}