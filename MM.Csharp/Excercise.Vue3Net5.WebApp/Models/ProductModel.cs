using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Vue3Net5.WebApp.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(long id, int categoryId, string name, string title, string description, string imageUrl, decimal price, int stockQuantity)
        {
            Id = id;
            CategoryId = categoryId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Image = imageUrl ?? throw new ArgumentNullException(nameof(imageUrl));
            Price = price;
            StockQuantity = stockQuantity;
        }

        public long Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public DateTime FetchedAt => System.DateTime.UtcNow;
    }
}
