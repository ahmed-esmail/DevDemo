﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public class Category
  {
    public Guid Id { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }
  }
}
