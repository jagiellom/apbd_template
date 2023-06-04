using Template.Services.TemplateService.Dto;

namespace Template.Services.Service.Abstract;

public interface IClientService
{
    Task<ICollection<ClientOrdersDto.Get>> GetOrdersByClientId(int id);
}