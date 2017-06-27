using JG.Domain.Entities;
using JG.Domain.Interfaces;

namespace JG.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
    }
}
