using Application.Features.Languages.DTOs;
using Application.Features.Languages.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Languages.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Lang, CreateLangRequestDto>().ReverseMap();
        CreateMap<Lang, CreatedLangResponseDto>().ReverseMap();
        CreateMap<IPaginate<Lang>, GetListLangModel>().ReverseMap();
        CreateMap<Lang, LangDto>().ReverseMap();
        CreateMap<Lang, UpdateLangRequestDto>().ReverseMap();
        CreateMap<Lang, UpdatedLangResponseDto>().ReverseMap();
    }
}