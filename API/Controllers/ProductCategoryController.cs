using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private IProductCategoryss _order;
        public ProductCategoryController(IProductCategoryss itemBusiness)
        {
            _order = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Model.ProductCategory CreateItem([FromBody] ProductCategory model)
        {
            _order.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public ProductCategory GetDatabyID(string id)
        {
            return _order.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<ProductCategory> GetDatabAll()
        {
            return _order.GetDataAll();
        }
    }
}
