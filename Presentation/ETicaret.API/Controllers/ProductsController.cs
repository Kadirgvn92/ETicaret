
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

    private readonly IOrderWriteRepository _orderWriteService;
    private readonly ICustomerWriteRepository _customerWriteService;
    private readonly IOrderReadRepository _orderReadRepository;

    public ProductsController(IProductWriteRepository productWriteService, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteService, ICustomerWriteRepository customerWriteService, IOrderReadRepository orderReadRepository)
    {
        _productWriteService = productWriteService;
        _productReadRepository = productReadRepository;
        _orderWriteService = orderWriteService;
        _customerWriteService = customerWriteService;
        _orderReadRepository = orderReadRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        Order order = await _orderReadRepository.GetByIDAsync("19e6f853-8d89-4c67-9976-5b71fb6bb1ea");
        order.Address = "İstanbul";
        await _orderWriteService.SaveAsync();
    }

}
