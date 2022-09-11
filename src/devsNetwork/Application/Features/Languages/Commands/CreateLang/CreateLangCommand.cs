using Application.Features.Languages.DTOs;
using MediatR;

namespace Application.Features.Languages.Commands.CreateLang;

public class CreateLangCommand:IRequest<CreatedLangResponseDto>
{
    public CreateLangRequestDto CreateLangRequestDto { get; set; }
}