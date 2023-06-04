using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Models;
using Template.Services.Service.Abstract;
using Template.Services.TemplateService.Dto;

namespace Template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrdersService _ordersService;
    private readonly Context _context;
    
    public OrdersController(IOrdersService ordersService, Context context)
    {
        _ordersService = ordersService;
        _context = context;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Post(int id, [FromBody] AddProductsDto dto)
    {
        return Created("api/orders/", new { id = id}))
    } 
}