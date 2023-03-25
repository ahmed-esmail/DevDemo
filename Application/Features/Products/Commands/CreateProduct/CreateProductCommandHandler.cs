using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Products.Commands.CreateProduct
{
  public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
  {
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
      _productRepository = productRepository;
      _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
      Product product = _mapper.Map<Product>(request);

      CreateCommonValidator validator = new CreateCommonValidator();
      var validationResult = await validator.ValidateAsync(request);

      if (validationResult.Errors.Any())
      {
        throw new Exception(validationResult.Errors.First().ErrorMessage);
      }

      product = await _productRepository.AddAsync(product);

      return product.Id;
    }
  }
}
