using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Loveseat", 101, 1000f, 1);
        Product p2 = new Product("Recliner", 102, 800f, 2);
        Product p3 = new Product("Couch", 103, 1500f, 1);
        Address address1 = new Address("45 Elm Street", "Milford", "CT", "USA");
        Customer customer1 = new Customer("Miguel De La Cruz", address1);

        List<Product> products1 = new List<Product> { p1, p2, p3 };
        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.Label());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Console.WriteLine("");

        Product p4 = new Product("Couch", 104, 1500f, 2);
        Product p5 = new Product("Recliner", 105, 800f, 3);

        Address address2 = new Address("203 Woodend Rd", "Stratford", "CT", "USA");
        Customer customer2 = new Customer("Maria Callejas", address2);

        List<Product> products2 = new List<Product> { p4, p5 };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine(order2.Label());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Console.WriteLine("");

        Product p6 = new Product("Couch", 106, 1500f, 2);
        Product p7 = new Product("Recliner", 107, 800f, 3);
        Product p8 = new Product("Loveseat", 108, 1000f, 4);


        Address address3 = new Address("Av. Javier Prado 1234", "Lima", "Lima", "Peru");
        Customer customer3 = new Customer("Maria Callejas", address3);

        List<Product> products3 = new List<Product> { p6, p7, p8 };
        Order order3 = new Order(products3, customer3);

        Console.WriteLine(order3.Label());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.TotalCost()}");
        Console.WriteLine("");
        
    }
}