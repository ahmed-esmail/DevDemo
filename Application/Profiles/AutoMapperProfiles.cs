using Application.Features.Products.Commands.CreateProduct;
using Application.Features.Products.Queries.GetProductList;
using AutoMapper;
using Domain;

namespace Application.Profiles
{
  public class AutoMapperProfiles : Profile
  {
    public AutoMapperProfiles()
    {
      CreateMap<Domain.Category, CategoryDto>();
      CreateMap<Domain.Product, GetPostsListViewModel>().ReverseMap();

      CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
  }
}
