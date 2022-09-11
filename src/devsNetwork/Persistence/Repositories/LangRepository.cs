using Application.IServices.IRepositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LangRepository:EfRepositoryBase<Lang,BaseDbContext>,ILangRepository
{
    public LangRepository(BaseDbContext context) : base(context)
    {
    }
}