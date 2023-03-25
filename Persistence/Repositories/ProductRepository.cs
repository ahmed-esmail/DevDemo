


using Application.Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace DevDemo.Persistence
{
  public class PostRepository : BaseRepository<Product>, IProductRepository
  {
    public PostRepository(ProductDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IReadOnlyList<Product>> GetAllProductAsync(bool includeCategory)
    { 
      // get all product
      List<Product> allPosts = new List<Product>();
      allPosts = await _dbContext.Products.ToListAsync();
      return allPosts;
    }

    public async Task<IReadOnlyList<Product>> GetProductsByNameAsync(string name)
    {
      return await _dbContext.Products.Include(x => x.Name == name).ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(Guid id)
    {
      return await _dbContext.Products.FindAsync(id);
    }
  }


}
