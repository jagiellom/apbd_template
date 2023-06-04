using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Template.Models;
using Template.Services.Service.Abstract;
using Template.Services.TemplateService.Dto;

namespace Template.Services.ClientService;

public class ClientService : IClientService
{
    private readonly Context _context;

    public ClientService(Context context)
    {
        _context = context;
    }

    public async Task<ICollection<ClientOrdersDto.Get>> GetOrdersByClientId(int id)
    {
        var dbResult = await _context.ProductOrders
            .Include(po => po.Product)
            .Include(po => po.Order)
            .ThenInclude(o => o.Status)
            .Include(po => po.Order)
            .ThenInclude(o => o.Client)
            .Where(c => c.Order.Client.Id == id)
            .ToListAsync();

        if (dbResult.Count == 0)
            return new List<ClientOrdersDto.Get>();

        var groupedOrders = dbResult.GroupBy(r => r.OrderId).ToList();
        

        var result = dbResult.Select(r =>
            new ClientOrdersDto.Get
            {
                OrderId = r.OrderId,
                ClientsLastName = r.Order.Client.LastName,
                CreatedAt = r.Order.CreatedAt,
                FulfilledAt = r.Order.FullfilledAt ?? null,
                Products = groupedOrders.First(e => e.Key == r.OrderId).Select(e => new ProductDto.Get()
                {
                    Amount = e.Amount,
                    Name = e.Product.Name,
                    Price = e.Product.Price
                }).ToList(),
                Status = r.Order.Status.Name
            });

        return result.ToList();
    }
}