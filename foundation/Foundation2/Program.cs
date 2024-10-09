using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Toronto", "ON", "Canada");
        Address address2 = new Address("456 Peakview Dr", "Bozeman", "Montana", "USA");

        Customer customer1 = new Customer("Ethan Smith", address1);
        Customer customer2 = new Customer("Brielle Martin", address2);

        Product product1 = new Product("King Cotton Sheet Set", 111489, 89.99, 1);
        Product product2 = new Product("Bamboo Cutting Board", 122579, 25.50, 2);
        Product product3 = new Product("Solar-Powered Outdoor String Lights", 229650, 22.00, 4);
        Product product4 = new Product("Set of 6 Stackable Storage Bins", 445998, 18.75, 1);
        Product product5 = new Product("Kitchen Towel Set (3 pack)", 349093, 12.00, 2);
        Product product6 = new Product("Bathroom Mat", 149329, 15.99, 1);
        Product product7 = new Product("Small Plant Pot with Succulent", 467833, 5.99, 3);
        Product product8 = new Product("LED Desk Lamp", 783700, 28.75, 1);
        Product product9 = new Product("Doormat with Welcome Message", 236774, 16.00, 1);
        Product product10 = new Product("Set of 4 Coffee Mugs", 602436, 25.00, 2);

        List<Product> products1 = new List<Product> {product1, product2, product3, product4, product5};
        List<Product> products2 = new List<Product> {product6, product7, product8, product9, product10};

        Order order1 = new Order(customer1, 5, 35);
        Order order2 = new Order(customer2, 5, 35);

        foreach (var product in products1)
        {
            order1.AddProduct(product);
        }

        foreach (var product in products2)
        {
            order2.AddProduct(product);
        }

        double subtotal1 = 0;
        foreach (var product in products1)
        {
            subtotal1 += product.ComputeTotalCost();
        }

        double subtotal2 = 0;
        foreach (var product in products2)
        {
            subtotal2 += product.ComputeTotalCost();
        }

        Console.WriteLine();
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine($"Subtotal: ${subtotal1:F2}");
        Console.WriteLine("Shipping: $35.00");
        Console.WriteLine($"Total: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine();
        
        Console.WriteLine("-----------------------------------------------------------------------------");

        Console.WriteLine();
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine($"Subtotal: ${subtotal2:F2}");
        Console.WriteLine("Shipping: $5.00");
        Console.WriteLine($"Total: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine();

    }
}