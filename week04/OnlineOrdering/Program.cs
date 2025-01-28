using System;
using System.Collections.Generic;

/* Added styling in the display of the orders with dotted lines.
    Added more products and customers and addresses and orders.
*/

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.00m, 1);
        Product product2 = new Product("Mouse", "P002", 25.00m, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00m, 1);
        Product product4 = new Product("Monitor", "P004", 300.00m, 2);
        Product product5 = new Product("USB Cable", "P005", 10.00m, 3);
        Product product6 = new Product("Headphones", "P006", 100.00m, 1);
        Product product7 = new Product("Webcam", "P007", 80.00m, 1);
        Product product8 = new Product("External Hard Drive", "P008", 150.00m, 2);
        Product product9 = new Product("Desk Lamp", "P009", 35.00m, 1);
        Product product10 = new Product("Office Chair", "P010", 200.00m, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Maple Ave", "Seattle", "WA", "USA");
        Address address4 = new Address("321 Oak Rd", "London", "", "UK");
        Address address5 = new Address("654 Pine Dr", "Melbourne", "", "Australia");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Alice Johnson", address3);
        Customer customer4 = new Customer("Bob Brown", address4);
        Customer customer5 = new Customer("Emily Davis", address5);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Order order3 = new Order(customer3);
        order3.AddProduct(product7);
        order3.AddProduct(product8);

        Order order4 = new Order(customer4);
        order4.AddProduct(product9);
        order4.AddProduct(product10);

        Order order5 = new Order(customer5);
        order5.AddProduct(product3);
        order5.AddProduct(product6);
        order5.AddProduct(product7);

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2, order3, order4, order5 };

        // Display details of each order
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Order {orderNumber} Details:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}\n");
            orderNumber++;
        }
    }
}