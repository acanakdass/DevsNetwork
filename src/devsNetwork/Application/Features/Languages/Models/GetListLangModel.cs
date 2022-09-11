using Application.Features.Languages.DTOs;
using Core.Persistence.Paging;

namespace Application.Features.Languages.Models;

public class GetListLangModel:BasePageableModel
{
    public IList<LangDto> Items { get; set; }
}