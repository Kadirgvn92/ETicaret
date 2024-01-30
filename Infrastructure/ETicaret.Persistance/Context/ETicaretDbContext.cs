﻿using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Context;
public class ETicaretDbContext : DbContext
{
    public ETicaretDbContext(DbContextOptions options) : base(options) //IOC üzerinden çağırdığımızda ayar yapabilmek için options'lı ctor oluşturuyoruz
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders  { get; set; }
    public DbSet<Customer> Customers  { get; set; }
}
