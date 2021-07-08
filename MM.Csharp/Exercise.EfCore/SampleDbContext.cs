using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Exercise.EfCore.Models
{
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.Extensions.Options;

    using Newtonsoft.Json;

    public partial class SampleDbContext : DbContext
    {
        public SampleDbContext()
        {
        }

        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=SampleDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.CategoryId, "IX_Product_CategoryId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4100);

                entity.Property(e => e.ImageUrl).HasMaxLength(250);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Electronics",
                        Description = "Articles defined in electronics type of merchandise.",
                        IsEnabled = true
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Jewelery",
                        Description = "Articles defined in jewelery type of merchandise.",
                        IsEnabled = true
                    }, new Category
                    {
                        Id = 3,
                        Name = "Men's Clothing",
                        Description = "Articles defined in men's clothing type of merchandise.",
                        IsEnabled = true
                    }, new Category
                    {
                        Id = 4,
                        Name = "Women's Clothing",
                        Description = "Articles defined in women's clothing type of merchandise.",
                        IsEnabled = true
                    });

            modelBuilder.Entity<Product>()
                .HasData(ProductJsonHelper.GenerateProducts());

            OnModelCreatingPartial(modelBuilder);
        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
