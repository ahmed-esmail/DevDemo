using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class ProductDbContext : DbContext
  {
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
      var productGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
      modelBuilder.Entity<Category>().HasData(new Category
      {
        Id = categoryGuid,
        CategoryName = "ewf",
        Description = "df"
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = productGuid,
        Name = "Introduction to CQRS and Mediator Patterns",
        ImageUrl = "https://api.khalidessaadani.com/uploads/articles_bg.jpg",
        CategoryId = new Guid("B0788D2F-8003-43C1-92A4-EDC76A7C5DDE"),
        CreatedBy = "WD",
        Description = "Dw",
        ImageThumbnailUrl = "https",
        Price = 324,
        InStock = false,
        DateCreated = new DateTime(),
        LastModifiedBy = "Ali",
        IsPreferredProduct = true,
        LastModifiedDate = new DateTime()
      });

    }
  }
}
