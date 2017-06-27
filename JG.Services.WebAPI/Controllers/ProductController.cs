using JG.Application.Interfaces;
using JG.Domain.Entities;
using JG.Services.WebAPI.Filters;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JG.Services.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        #region [ Contantes ]

        const string URI_GET_PRODUCTS = "Product/Get";

        #endregion

        private readonly IProductApplication _productApplication;

        public ProductController(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }

        [HttpGet]
        [AuthenticationFilter]
        [Route(URI_GET_PRODUCTS)]
        public ResponseServer<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> products = null;
            Error error = null;

            try
            {
                products = _productApplication.Get();
            }
            catch (Exception ex)
            {
                error = new Error();
                error.Message = ex.Message;
            }

            return ResponseServer<IEnumerable<Product>>.GetResponse(products, error);
        }
    }
}
