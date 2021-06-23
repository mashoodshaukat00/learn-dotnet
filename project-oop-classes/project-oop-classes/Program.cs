using System;

namespace project_oop_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProduct = new Product(1, "T-shirt", "white and round neck", 24.99, "www.image.com/tshirt.jpg");
            Console.WriteLine($"The product with Id: {myProduct.Id} and name: {myProduct.Name} was bought at price ${myProduct.Price}");
        }
    }
}
