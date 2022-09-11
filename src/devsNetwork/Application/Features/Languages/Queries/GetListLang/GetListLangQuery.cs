using Application.Features.Languages.Models;
using Core.Application.Requests;
using MediatR;

namespace Application.Features.Languages.Queries.GetListLang;

public class GetListLangQuery:IRequest<GetListLangModel>
{
    public PageRequest PageRequest { get; set; }
}