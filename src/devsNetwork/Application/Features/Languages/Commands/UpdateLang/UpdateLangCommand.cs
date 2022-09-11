using System.Windows.Input;
using Application.Features.Languages.DTOs;
using MediatR;

namespace Application.Features.Languages.Commands.UpdateLang;

public class UpdateLangCommand:IRequest<UpdatedLangResponseDto>
{
    public UpdateLangRequestDto UpdateLangRequestDto { get; set; }
}