using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.IServices.IRepositories;

public interface ILangRepository:IAsyncRepository<Lang>,IRepository<Lang>
{
    
}