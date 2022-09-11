using Application.Features.Languages.Models;
using Application.IServices.IRepositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Queries.GetListLang;

public class GetListLangQueryHandler : IRequestHandler<GetListLangQuery, GetListLangModel>
{
    private readonly ILangRepository _langRepository;
    private readonly IMapper _mapper;

    public GetListLangQueryHandler(IMapper mapper, ILangRepository langRepository)
    {
        _mapper = mapper;
        _langRepository = langRepository;
    }

    public async Task<GetListLangModel> Handle(GetListLangQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Lang> result =
            await _langRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
        GetListLangModel listLangModel = _mapper.Map<GetListLangModel>(result);
        return listLangModel;
    }
}