using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.EfCore.Models;
using Exercise.SampleDb.WebApi.Models;
using Exercise.SampleDb.WebApi.Services;

namespace Exercise.SampleDb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<ProductModel>> GetProducts()
        {
            return _service.GetAllAsync();
        }

        [HttpPost]
        public Task AddProduct([FromBody] ProductModel model)
        {
            return _service.AddAsync(model);
        }
    }
}
