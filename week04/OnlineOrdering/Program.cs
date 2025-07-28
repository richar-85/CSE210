using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("850 Parkway Dr", "Blackfoot", "ID", "USA");
        Customer customer1 = new Customer("Richard Udonsa", address1);

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 499.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.50, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("HP-Printer", "P2001", 150.00, 1));
        order2.AddProduct(new Product("USB Cable", "P2002", 10.00, 3));  

        List<Order> orders = new List<Order> { order1, order2 };
            
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
            Console.WriteLine();
        }
        
    }
}