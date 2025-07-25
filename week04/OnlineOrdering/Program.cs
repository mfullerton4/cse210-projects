using System;

class Program
{
    static void Main(string[] args)
    {
        //Create first customer and address
        Address address1 = new Address("123 Elm Street", "Springville", "UT", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        //Create products for first order
        Product product1 = new Product("Notebook", "N123", 2.5, 3);
        Product product2 = new Product("Pen", "P456", 1.25, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        //Create second customer and address
        Address address2 = new Address("45 Cherry Lane", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Jones", address2);

        //Create products for second order and address
        Product product3 = new Product("stapler", "S789", 5.0, 1);
        Product product4 = new Product("Tape", "T234", 3.5, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Display results for both orders
        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());

        Console.WriteLine();

        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());
    }
}