using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Bread", 223, 20, 3);
        Product product2 = new Product("Hamburger Buns", 110, 30, 4 );
        Address address1 = new Address("2244 street", "Dallas", "Texas", "USA");
        Customer customer1 = new Customer("Customer 1", address1);

        Order order1 = new Order(customer1);
        order1._products.Add(product1);
        order1._products.Add(product2);

        Console.WriteLine("Order final cost: ");
        Console.WriteLine($"${order1.CalculateFinalCost()}\n");

        Console.WriteLine("Shipping label order: ");
        Console.WriteLine($"{order1.GetShippingLabel()}\n");

        Console.WriteLine("Packing order: ");

        foreach (var item in order1.GetPackingLabel())
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("\n");

        Product product3 = new Product("iPhone", 344, 22, 4);
        Product product4 = new Product("Water", 20, 10, 1);
        Address address2 = new Address("8899 street", "Spring", "Texas", "USA");
        Customer customer2 = new Customer("Customer 2", address2);

        Order order2 = new Order(customer2);
        order2._products.Add(product3);
        order2._products.Add(product4);

        Console.WriteLine("Order final cost: ");
        Console.WriteLine($"${order2.CalculateFinalCost()}\n");

        Console.WriteLine("Shipping label order: ");
        Console.WriteLine($"{order2.GetShippingLabel()}\n");

        Console.WriteLine("Packing order: ");

        foreach (var item in order2.GetPackingLabel())
        {
            Console.WriteLine($"{item}\n");
        }
    }
}