
using System.Collections.Generic;

namespace JG.Domain.Interfaces
{
    public interface IServiceBase<Entity> where Entity : class
    {
        IEnumerable<Entity> Get();
    }
}
