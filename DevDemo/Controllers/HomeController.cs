using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Products.Queries.GetProductList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevDemo.Controllers
{
  public class HomeController : Controller
  {
    private readonly IMediator _mediator;

    public HomeController(IMediator mediator)
    {
      _mediator = mediator;
    }
    public async Task<IActionResult> Index()
    {
      var data = await _mediator.Send(new GetPostListQuery());
      return View(data);
    }

    public IActionResult About()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View();
    }
  }
}
