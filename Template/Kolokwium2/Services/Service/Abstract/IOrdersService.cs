using Template.Services.TemplateService.Dto;

namespace Template.Services.Service.Abstract;

public interface IOrdersService
{
    Task AddProductsToOrderAsync(AddProductsDto dto);
}