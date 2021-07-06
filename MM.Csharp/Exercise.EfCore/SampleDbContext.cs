using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Exercise.EfCore.Models
{
    using Microsoft.Extensions.Options;

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
            //             if (!optionsBuilder.IsConfigured)
            //             {
            // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //                 optionsBuilder.UseSqlServer("Server=.\\SQLSERVER;Database=SampleDb;Trusted_Connection=True;");
            //             }
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
                        .HasMaxLength(50);

                    entity.Property(e => e.ImageUrl).HasMaxLength(50);

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
                        Name = "Clothing",
                        Description = "Articles defined in clothing type of merchandise.",
                        IsEnabled = true
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Watches",
                        Description = "Articles defined in clothing type of merchandise.",
                        IsEnabled = true
                    });
            
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product()
                    {
                        Id = 1,
                        Name = "T-Shirt",
                        CategoryId = 1,
                        Title = "West Minister Tee",
                        Description = "Round neck regular fit t-shirt",
                        ImageUrl = "Google.com",
                        Price = 24.02M,
                        StockQuantity = 100

                    });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
