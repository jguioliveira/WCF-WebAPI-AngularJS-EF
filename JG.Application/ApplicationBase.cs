
using System;
using System.Collections.Generic;
using JG.Application.Interfaces;
using JG.Domain.Interfaces;

namespace JG.Application
{
    public class ApplicationBase<Entity> : IApplicationBase<Entity> where Entity : class
    {
        private IServiceBase<Entity> _service;

        public ApplicationBase(IServiceBase<Entity> service)
        {
            _service = service;
        }
         
        public IEnumerable<Entity> Get()
        {
            return _service.Get();
        }
    }
}
