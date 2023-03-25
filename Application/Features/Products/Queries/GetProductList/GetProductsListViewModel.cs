using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.GetProductList
{
  public class GetPostsListViewModel
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsPreferredProduct { get; set; }
    public bool InStock { get; set; }
    public string Description { get; set; }

    public CategoryDto Category { get; set; }

  }
}
