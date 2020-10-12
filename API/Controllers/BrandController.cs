using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IBrandss _brand;
        public BrandController(IBrandss itemBusiness)
        {
            _brand = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Brand CreateItem([FromBody] Brand model)
        {
            _brand.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Brand GetDatabyID(string id)
        {
            return _brand.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Brand> GetDatabAll()
        {
            return _brand.GetDataAll();
        }
    }
}
