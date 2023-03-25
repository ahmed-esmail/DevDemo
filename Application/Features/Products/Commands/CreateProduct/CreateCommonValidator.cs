using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Features.Products.Commands.CreateProduct
{
  public class CreateCommonValidator : AbstractValidator<CreateProductCommand>
  {
    public CreateCommonValidator()
    {
      RuleFor(p => p.Name)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
      RuleFor(p => p.Description)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");
      RuleFor(p => p.ImageUrl)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
      RuleFor(p => p.CategoryId)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull();
    }
  }
}
