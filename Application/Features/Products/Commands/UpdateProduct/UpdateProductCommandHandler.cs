using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Products.Commands.UpdateProduct
{
  public class UpdateProductCommandHandler
  {
    private readonly IAsyncRepository<Product> _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductCommandHandler(IAsyncRepository<Product> productRepository, IMapper mapper)
    {
      _productRepository = productRepository;
      _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
      Product product = _mapper.Map<Product>(request);

      await _productRepository.UpdateAsync(product);

      return Unit.Value; 
    }   
  }
}
