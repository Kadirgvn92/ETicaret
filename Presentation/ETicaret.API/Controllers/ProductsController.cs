
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
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
    public async Task Get()
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
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        Product product = await _productReadRepository.GetByIDAsync(id);
        return Ok(product);
    }

}
