using Application.Features.Languages.Commands.CreateLang;
using FluentValidation;

namespace Application.Features.Languages.Validators;

public class CreateLangCommandValidators:AbstractValidator<CreateLangCommand>
{
    public CreateLangCommandValidators()
    {
        RuleFor(x => x.CreateLangRequestDto.Name).NotEmpty();
    }
}