namespace Template.Services.TemplateService.Dto;

public class ClientOrdersDto
{
    public class Get
    {
        public int OrderId { get; set; }
        public string ClientsLastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? FulfilledAt { get; set; }
        public string Status { get; set; }
        public ICollection<ProductDto.Get> Products { get; set; }
    }
}