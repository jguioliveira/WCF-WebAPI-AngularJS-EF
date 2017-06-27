using System.Collections.Generic;

namespace JG.Application.Interfaces
{
    public interface IApplicationBase<Entity> where Entity : class
    {
        IEnumerable<Entity> Get();
    }
}
