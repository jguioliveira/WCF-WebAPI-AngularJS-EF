
using JG.Application.Interfaces;
using JG.Domain.Entities;
using JG.Domain.Interfaces;

namespace JG.Application
{
    public class ProductApplication : ApplicationBase<Product>, IProductApplication
    {
        private readonly IProductService _service;
        public ProductApplication(IProductService service) : base(service)
        {
            _service = service;
        }

    }
}
