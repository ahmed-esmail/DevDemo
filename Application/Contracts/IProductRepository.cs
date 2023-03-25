using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Contracts
{
  public interface IProductRepository : IAsyncRepository<Product>
  {
    Task<IReadOnlyList<Product>> GetAllProductAsync (bool includeCategory);
    Task<IReadOnlyList<Product>> GetProductsByNameAsync(string name);
    Task<Product> GetProductByIdAsync(Guid id);
  }
}
 