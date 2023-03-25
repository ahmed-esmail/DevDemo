using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Products.Commands.CreateProduct
{
  public class CreateProductCommand : IRequest<Guid>
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
  }
}
