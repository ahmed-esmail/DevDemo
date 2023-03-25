using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.Products.Queries.GetProductList
{
  public class GetProductListQueryHandler : IRequestHandler<GetPostListQuery, List<GetPostsListViewModel>>
  {
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductListQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
      _productRepository = productRepository;
      _mapper = mapper;
    }

    public async Task<List<GetPostsListViewModel>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
    {
      var productList = await _productRepository.GetAllProductAsync(true);
      var mappedProducts = _mapper.Map<List<GetPostsListViewModel>>(productList);
      return mappedProducts;
    }
  }
}
