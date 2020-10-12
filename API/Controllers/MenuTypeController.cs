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
    public class MenuTypeController : ControllerBase
    {
        private IMenuTypess _menutype;
        public MenuTypeController(IMenuTypess itemBusiness)
        {
            _menutype = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public MenuType CreateItem([FromBody] MenuType model)
        {
            _menutype.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public MenuType GetDatabyID(string id)
        {
            return _menutype.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<MenuType> GetDatabAll()
        {
            return _menutype.GetDataAll();
        }
    }
}
