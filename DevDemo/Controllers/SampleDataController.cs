using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Application.Features.Products.Queries.GetProductList;
using DevDemo.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevDemo.Controllers
{

  [Route("api/[controller]")]
  public class SampleDataController : Controller
  {
    private readonly IMediator _mediator;

    public SampleDataController(IMediator mediator)
    {
      _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
    {
      var data = await _mediator.Send(new GetPostListQuery());
      return View((IEnumerable<Product>)data);
    }

  }
}