using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Exercise.EfCore.Models;
using Exercise.Vue3Net5.WebApp.Models;

using Microsoft.EntityFrameworkCore;

namespace Exercise.Vue3Net5.WebApp.Services
{
    public class ProductService
    {
        private readonly SampleDbContext _context;

        public ProductService(SampleDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();

            var models = new List<ProductModel>();

            foreach (var product in result)
            {
                models.Add(MapEntityToModel(product));
            }

            return models;
        }

        private static ProductModel MapEntityToModel(Product product)
        {
            return new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Title = product.Title,
                Description = product.Description,
                CategoryId = product.CategoryId,
                StockQuantity = product.StockQuantity,
                Image = product.ImageUrl
            };
        }

        private static Product MapModelToEntity(ProductModel model)
        {
            return new Product()
            {
                Name = model.Name,
                Title = model.Title,
                Description = model.Description,
                CategoryId = model.CategoryId,
                StockQuantity = model.StockQuantity,
                ImageUrl = model.Image
            };
        }

        public async Task<ProductModel> AddAsync(ProductModel model)
        {
            var product = MapModelToEntity(model);
            await _context.Products.AddAsync(product);
            var results = await _context.SaveChangesAsync();

            if (results > 0)
            {
                return MapEntityToModel(product);
            }
            else
            {
                throw new Exception("Product not added to the database.");
            }
        }


    }
}
