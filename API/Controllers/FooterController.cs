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
    public class FooterController : ControllerBase
    {
        private IFooterss _footer;
        public FooterController(IFooterss itemBusiness)
        {
            _footer = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Footer CreateItem([FromBody] Footer model)
        {
            _footer.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Footer GetDatabyID(string id)
        {
            return _footer.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Footer> GetDatabAll()
        {
            return _footer.GetDataAll();
        }
    }
}
