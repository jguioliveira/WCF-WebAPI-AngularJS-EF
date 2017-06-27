using JG.Domain.Entities;
using JG.Domain.Interfaces;

namespace JG.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
