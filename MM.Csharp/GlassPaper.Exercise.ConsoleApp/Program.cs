using GlassPaper.Exercise.ClassLibrary.Exercise1;
using System;

namespace GlassPaper.Exercise.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This is my {nameof(Product)}!");
                        
            IProduct product = new Product
            {
                Id = 1,
                Name = "T-Shirt",
                Description = "White & round neck",
                Price = 24.99M,
                ImageUri = new Uri("http://www.image.com/tshirt.jpg")
            };

            Console.WriteLine(product.GetProductDetail());
        }
    }
}
