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
    public class OrderController : ControllerBase
    {
        private IOrderss _order;
        public OrderController(IOrderss itemBusiness)
        {
            _order = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Order CreateItem([FromBody] Order model)
        {
            _order.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Order GetDatabyID(string id)
        {
            return _order.GetDatabyID(id);
        }


        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Order> GetDatabAll()
        {
            return _order.GetDataAll();
        }

        //trang thai don hang
        [Route("change-status/{id}/{msg}")]
        [HttpGet]
        public bool changeStatus(int id, string msg)
        {
            return _order.changeStatus(id, msg);
        }

        //xem chi tiet don hang
        [Route("get-bill-detail/{id}")]
        [HttpGet]
        public List<OrderDetail> GetBillDetail(string id)
        {
            return _order.GetBillByID(id);
        }

        //xoa don hang
        [Route("delete-bill/{id}")]

        [HttpGet]
        public bool Delete(int id)
        {
            return _order.Delete(id);
        }
    }
}
