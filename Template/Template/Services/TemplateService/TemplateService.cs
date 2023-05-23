using AutoMapper;
using Template.Models;
using Template.Services.TemplateService.Abstract;

namespace Template.Services.TemplateService;

public class TemplateService : ITemplateService
{
    private readonly Context _context;
    private readonly IMapper _mapper;

    public TemplateService(Context context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
}