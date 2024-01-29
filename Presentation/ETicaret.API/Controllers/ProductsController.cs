﻿using ETicaret.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IActionResult GetProducts()
    {
        var values = _productService.GetProducts();
        return Ok(values);
    }
}