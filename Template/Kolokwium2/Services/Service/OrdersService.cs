using Template.Models;
using Template.Services.Service.Abstract;
using Template.Services.TemplateService.Dto;

namespace Template.Services.Service;

public class OrdersService : IOrdersService
{
    private readonly Context _context;
    
    public OrdersService(Context context)
    {
        _context = context;
    }
    
    public Task AddProductsToOrderAsync(AddProductsDto dto)
    {
        throw new NotImplementedException();
    }
}