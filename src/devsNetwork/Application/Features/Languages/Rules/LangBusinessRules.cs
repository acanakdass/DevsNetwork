using Application.IServices.IRepositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Languages.Rules;

public class LangBusinessRules
{
    private readonly ILangRepository _langRepository;

    public LangBusinessRules(ILangRepository langRepository)
    {
        _langRepository = langRepository;
    }

    public async Task LangNameCanNotBeDuplicatedWhenInserted(string name)
    {
        var lang = await _langRepository.GetAsync(b => b.Name == name);
        if (lang!=null) throw new BusinessException($"Lang with name {name} exists.");
    }
}