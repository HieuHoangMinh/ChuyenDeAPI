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
    public class MenuController : ControllerBase
    {
        private IMenuss _menu;
        public MenuController(IMenuss itemBusiness)
        {
            _menu = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Menu CreateItem([FromBody] Menu model)
        {
            _menu.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Menu GetDatabyID(string id)
        {
            return _menu.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Menu> GetDatabAll()
        {
            return _menu.GetDataAll();
        }
    }
}
