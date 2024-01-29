using ETicaret.Application.Abstractions;
using ETicaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Concrete;
public class ProductService : IProductService
{
    public List<Product> GetProducts() => new()
    {
        new () 
        { 
            ID= Guid.NewGuid(),
            Name = "Product 1",
            Stock = 10,
            Price = 1000,
        },
        new ()
        {
            ID= Guid.NewGuid(),
            Name = "Product 2",
            Stock = 10,
            Price = 200,
        },
        new ()
        {
            ID= Guid.NewGuid(),
            Name = "Product 3",
            Stock = 10,
            Price = 2000,
        },
        new ()
        {
            ID= Guid.NewGuid(),
            Name = "Product 4",
            Stock = 10,
            Price = 4500,
        },
        new ()
        {
            ID= Guid.NewGuid(),
            Name = "Product 5",
            Stock = 10,
            Price = 900,
        }
    };
}
