
using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Lang:Entity
{
    public string Name { get; set; }
    private Lang()
    {
    }
    public Lang(int id, string name):this()
    {
        Id = id;
        Name = name;
    }

}