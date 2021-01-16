using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.Content = "Amasya in Apple";
            product1.Price = 15.0;

            Product product2 = new Product();
            product2.ProductName = "Lemon";
            product2.Price = 80.0;
            product2.Content = "Good Lemon";

            Product [] products = new Product [] {product1,product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Content);
                Console.WriteLine(product.Price);
                Console.WriteLine("*********************");
            }

            Console.WriteLine("-------------Methods-------------");

            BoxManager boxManager = new BoxManager();
            boxManager.Add(product1);
            boxManager.Add(product2);

            boxManager.Add2("Banana","Yellow Banana",12);
            boxManager.Add2("Starbarry", "Red starbarry", 12);
            boxManager.Add2("Green Apple", "Green Apple", 12);


        }
    }
}
