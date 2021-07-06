using System;
using System.Collections.Generic;

#nullable disable

namespace Exercise.EfCore.Models
{
    public partial class Product
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public virtual Category Category { get; set; }
    }
}
