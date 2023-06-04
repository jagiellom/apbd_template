using Microsoft.AspNetCore.Mvc;
using Template.Services.Service.Abstract;
using Template.Services.TemplateService.Dto;

namespace Template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IClientService _service;

    public ClientsController(IClientService service)
    {
        _service = service;
    }
    
    
    [HttpGet("{id}/orders")]
    public async Task<IActionResult> GetOrders(int id)
    {
        var result = await _service.GetOrdersByClientId(id);

        if (!result.Any())
            return NotFound();
        
        return Ok(result);
    }
}