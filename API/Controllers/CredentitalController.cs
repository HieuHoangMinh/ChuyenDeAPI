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
    public class CredentitalController : ControllerBase
    {
        private ICredentitalss _credentital;
        public CredentitalController(ICredentitalss itemBusiness)
        {
            _credentital = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Credentital CreateItem([FromBody] Credentital model)
        {
            _credentital.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Credentital GetDatabyID(string id)
        {
            return _credentital.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Credentital> GetDatabAll()
        {
            return _credentital.GetDataAll();
        }
    }
}
