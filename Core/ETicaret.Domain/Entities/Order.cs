﻿using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Domain.Entities;
public class Order : BaseEntity
{
    public Guid CustomerID { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public ICollection<Product> Products { get; set; }
    public Customer Customers { get; set; }
}
