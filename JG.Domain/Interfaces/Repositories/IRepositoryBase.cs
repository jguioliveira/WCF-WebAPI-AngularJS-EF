using System.Collections.Generic;

namespace JG.Domain.Interfaces
{
    public interface IRepositoryBase<Entity> where Entity : class
    {
        IEnumerable<Entity> Get();
        Entity Get(int id);
        void Insert(Entity item);
        void Update(Entity item);
        void Delete(Entity item);
    }
}
