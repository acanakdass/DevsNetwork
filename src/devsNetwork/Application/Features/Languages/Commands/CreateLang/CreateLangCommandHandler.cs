using Application.Features.Languages.DTOs;
using Application.Features.Languages.Rules;
using Application.IServices.IRepositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.CreateLang;

public class CreateLangCommandHandler:IRequestHandler<CreateLangCommand,CreatedLangResponseDto>
{
    private readonly ILangRepository _langRepository;
    private readonly IMapper _mapper;
    private readonly LangBusinessRules _langBusinessRules;

    public CreateLangCommandHandler(ILangRepository langRepository, IMapper mapper, LangBusinessRules langBusinessRules)
    {
        _langRepository = langRepository;
        _mapper = mapper;
        _langBusinessRules = langBusinessRules;
    }

    public async Task<CreatedLangResponseDto> Handle(CreateLangCommand request, CancellationToken cancellationToken)
    {
        await _langBusinessRules.LangNameCanNotBeDuplicatedWhenInserted(request.CreateLangRequestDto.Name);
        Lang mappedLang = _mapper.Map<Lang>(request.CreateLangRequestDto);
        Lang createdLangResponse = await _langRepository.AddAsync(mappedLang);
        CreatedLangResponseDto response = _mapper.Map<CreatedLangResponseDto>(createdLangResponse);
        return response;
    }
}