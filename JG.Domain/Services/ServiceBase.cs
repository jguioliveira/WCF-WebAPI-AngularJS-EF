using System.Collections.Generic;
using JG.Domain.Interfaces;

namespace JG.Domain.Services
{
    public class ServiceBase<Entity> : IServiceBase<Entity> where Entity : class
    {
        private IRepositoryBase<Entity> _repository;

        public ServiceBase(IRepositoryBase<Entity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Entity> Get()
        {
            return _repository.Get();
        }
    }
}
