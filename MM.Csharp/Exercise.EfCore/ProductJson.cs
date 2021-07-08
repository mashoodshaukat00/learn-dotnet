using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace Exercise.EfCore.Models
{
    internal class ProductJson
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }

    internal static class ProductJsonHelper
    {
        internal static List<Product> GenerateProducts()
        {

            var data = JsonConvert.DeserializeObject<List<ProductJson>>(File.ReadAllText(@"D:\Documentation\Nav IT Kurs\Utvikling\learn-dotnet\MM.Csharp\Exercise.EfCore\product-data.json"));
            var products = new List<Product>();

            var counter = 1;
            foreach (var prod in data)
            {
                products.Add(new Product()
                {
                    Id = counter,
                    Name = prod.title,
                    CategoryId = GetCategoryId(prod.category),
                    Title = prod.title,
                    Description = prod.description,
                    ImageUrl = prod.image,
                    Price = (decimal)prod.price,
                    StockQuantity = 100
                });

                counter++;
            }

            return products;
        }

        internal static int GetCategoryId(string category)
        {
            int result = 0;
            switch (category.ToLower())
            {
                case "electronics":
                    result = 1;
                    break;

                case "jewelery":
                    result = 2;
                    break;

                case "men's clothing":
                    result = 3;
                    break;

                case "women's clothing":
                    result = 4;
                    break;
            }

            return result;
        }
    }
}