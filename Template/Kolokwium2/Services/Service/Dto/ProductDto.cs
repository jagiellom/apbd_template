namespace Template.Services.TemplateService.Dto;

public class ProductDto
{
    public class Get
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}