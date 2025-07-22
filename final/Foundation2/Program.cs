using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Zhang", address2);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Window wipe", "W123", 3.99, 4));
        order1.AddProduct(new Product("Garage rug", "G456", 7.50, 2));

        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 12.25, 1));
        order2.AddProduct(new Product("Doohickey", "D012", 5.75, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");

        Console.ReadLine();
    }
}