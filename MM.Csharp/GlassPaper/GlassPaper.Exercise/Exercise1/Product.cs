using System;

namespace GlassPaper.Exercise.ClassLibrary.Exercise1
{
    /// <summary>
    /// Class <c>Product</c> models a Product object.
    /// </summary>
    public class Product :  IProduct
    {
        /// <summary>
        /// <c>Id</c> will be used to identify a specific Product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// <c>Name</c> of the Product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// <c>Description</c> describes the Product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// <c>Price</c> denotes price of the Product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// <c>ImageUri</c> will hold image url.
        /// </summary>
        public Uri ImageUri { get; set; }

        /// <summary>
        /// Default <c>Product</c> constructor
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Parameterized <c>Product</c> constructor to initilize properties of the product.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="imageUri"></param>
        public Product(int id, string name, string description, decimal price, Uri imageUri)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.ImageUri = imageUri;
        }

        /// <summary>
        /// <c>GetProductDetail</c> return a string details of Product.
        /// </summary>
        /// <returns></returns>
        public string GetProductDetail()
        {
            string productDetail = $"The product with Id: {Id} and Name: {Name} was bought at Price ${Price}";

            return productDetail;
        }
    }
}
