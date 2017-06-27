
using System;
using System.Collections.Generic;
using JG.Domain.Interfaces;
using JG.Infra.Data.Context;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;

namespace JG.Infra.Data.Repositories
{
    public class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class
    {
        protected ProductContext db = new ProductContext();

        public void Delete(Entity item)
        {
            //TODO: Implementar método Delete
            throw new NotImplementedException();
        }

        public IEnumerable<Entity> Get()
        {
            return db.Set<Entity>().ToList();
        }

        public Entity Get(int id)
        {
            //TODO: Implementar método Get(id)
            throw new NotImplementedException();
        }

        public void Insert(Entity item)
        {
            //TODO: Implementar método Insert
            throw new NotImplementedException();
        }

        public void Update(Entity item)
        {
            //TODO: Implementar método Update
            throw new NotImplementedException();
        }
    }
}
