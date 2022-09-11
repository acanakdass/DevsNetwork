using Application.Features.Languages.DTOs;
using Application.IServices.IRepositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.UpdateLang;

public class UpdateLangCommandHandler : IRequestHandler<UpdateLangCommand, UpdatedLangResponseDto>
{
    private readonly ILangRepository _langRepository;
    private readonly IMapper _mapper;

    public UpdateLangCommandHandler(ILangRepository langRepository, IMapper mapper)
    {
        _langRepository = langRepository;
        _mapper = mapper;
    }

    public async Task<UpdatedLangResponseDto> Handle(UpdateLangCommand request, CancellationToken cancellationToken)
    {
        Lang lang = _mapper.Map<Lang>(request.UpdateLangRequestDto);
        var updateRes = await _langRepository.UpdateAsync(lang);
        UpdatedLangResponseDto response = _mapper.Map<UpdatedLangResponseDto>(updateRes);
        return response;
    }
}