using System;

class Program
{
    static void Main(string[] args)
    {
        Product banana = new Product("Banana", 1, 2.50, 10);
        Product apple = new Product("Apple", 2, 4.20, 15);
        Product pineapple = new Product("Pineapple", 3, 5.00, 3);
        Product orange = new Product("Orange", 4, 1.20, 50);
        Product watermelon = new Product("Watermelon", 6, 7.70, 30);

        Address alexAdress = new Address("Jose Reuter 1420", "Blumenau", "Santa Catarina", "Brazil");
        Address wilssonAdress = new Address("1234 Elm Street", "Springfield", "IL", "USA");

        Customer alex = new Customer("Alex", alexAdress);
        Customer wilsson = new Customer("Wilsson", wilssonAdress);

        Order n1 = new Order(alex);
        n1.AddProduct(apple);
        n1.AddProduct(pineapple);
        n1.AddProduct(watermelon);

        Order n2 = new Order(wilsson);
        n2.AddProduct(banana);
        n2.AddProduct(watermelon);
        n2.AddProduct(orange);

        Console.WriteLine(n1.ShippingLabel());
        Console.WriteLine(n1.PackingLabel());
        n1.CalculateTotalCost();
        Console.WriteLine($"Total cost: {n1.TotalCost}");
        Console.WriteLine(" ");

        Console.WriteLine(n2.ShippingLabel());
        Console.WriteLine(n2.PackingLabel());
        n2.CalculateTotalCost();
        Console.WriteLine($"Total cost: {n2.TotalCost}");
    }
}