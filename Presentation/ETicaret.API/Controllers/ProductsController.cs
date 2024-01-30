
using ETicaret.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductWriteRepository _productWriteService;
    private readonly IProductReadRepository _productReadRepository;

    public ProductsController(IProductWriteRepository productWriteService, IProductReadRepository productReadRepository)
    {
        _productWriteService = productWriteService;
        _productReadRepository = productReadRepository;
    }

    [HttpGet]
    public async void Get()
    {
       await _productWriteService.AddRangeAsync(new()
        {
            new ()
            {
                ID = Guid.NewGuid(),
                Name = "Product1",
                Stock = 10,
                Price = 1100,
                CreatedDate = DateTime.UtcNow
            },
             new ()
            {
                ID = Guid.NewGuid(),
                Name = "Product1",
                Stock = 10,
                Price = 1100,
                CreatedDate = DateTime.UtcNow
            },
              new ()
            {
                ID = Guid.NewGuid(),
                Name = "Product1",
                Stock = 10,
                Price = 1100,
                CreatedDate = DateTime.UtcNow
            }
        });
        await _productWriteService.SaveAsync();
    }
}
