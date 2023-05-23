using Microsoft.AspNetCore.Mvc;
using Template.Services.TemplateService.Abstract;
using Template.Services.TemplateService.Dto;

namespace Template.Controllers;

[ApiController]
[Route("[controller]")]
public class TemplateController : ControllerBase
{
    private readonly ITemplateService _service;

    public TemplateController(ITemplateService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    // raczej int, ew string/guid
    public async Task<IActionResult> GetById(int  id)
    {
        return Ok();
    }
    
    [HttpPut("{id}")]
    // raczej int, ew string/guid
    public async Task<IActionResult> Put(int id,  TemplateDto dto)
    {
        return Ok();
    }
    
    [HttpPost]
    // raczej int, ew string/guid
    public async Task<IActionResult> Post(TemplateDto dto)
    {
        return Ok();
    }
}