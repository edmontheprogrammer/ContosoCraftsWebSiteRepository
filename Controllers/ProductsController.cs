using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsService productsService)
        {
            this.ProductsService = productsService; 
        }

        public JsonFileProductsService ProductsService
        {
            get;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return (IEnumerable<Product>)ProductsService.GetProducts(); 
        }
    }
}
