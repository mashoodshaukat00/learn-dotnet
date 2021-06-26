using System;

namespace GlassPaper.Exercise.ClassLibrary.Exercise1
{
    public interface IProduct
    {
        string Description { get; set; }
        int Id { get; set; }
        Uri ImageUri { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }

        string GetProductDetail();
    }
}