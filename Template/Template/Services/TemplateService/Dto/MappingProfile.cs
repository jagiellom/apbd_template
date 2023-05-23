using AutoMapper;

namespace Template.Services.TemplateService.Dto;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Models.Entities.Template, TemplateDto.Get>()
            .ForMember(d => d.Id, m => m.MapFrom(s => s.TemplateId));

        CreateMap<TemplateDto, Models.Entities.Template>();
    }
}