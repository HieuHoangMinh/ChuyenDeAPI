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
    public class ProductController : ControllerBase
    {
        private IProductss _order;
        public ProductController(IProductss itemBusiness)
        {
            _order = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Model.Product CreateItem([FromBody] Product model)
        {
            _order.Create(model);
            return model;
        }

        //update
        [Route("update-item")]
        [HttpPost]
        public Model.Product UpdateItem([FromBody] Product model)
        {
            _order.Update(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Product GetDatabyID(int id)
        {
            return _order.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Product> GetDatabAll()
        {
            return _order.GetDataAll();
        }
        [Route("sp-by-loai/{page_index}/{page_size}/{category_id}")]
        [HttpGet]
        public IEnumerable<Product> GetByLoai(int page_index,
                                      int page_size,
                                       int category_id)
            
        {
            long total = 0;
           var kq= _order.GetByLoai(page_index,page_size,category_id,out total);
            foreach (var item in kq) {
                item.total = total;
            }
            return kq;
        }
        [Route("search/{pageIndex}/{pageSize}/{name}/{categoryid}")]
        [HttpGet]
        public ResponseModel Search(int pageIndex, int pageSize,string name, int? categoryid)
        {
            var response = new ResponseModel();
         
            long total = 0;
           
            if(categoryid==0)
            response.Data = _order.Search(pageIndex, pageSize,out total, name, null);
            else
                response.Data = _order.Search(pageIndex, pageSize, out total, name, (categoryid.Value));
            response.TotalItems = total;
            response.Page = pageIndex;
            response.PageSize = pageSize;
            return response;
        }

        [Route("delete-product")]
        [HttpPost]
        public IActionResult DeleteProduct([FromBody] Dictionary<string, object> formData)
        {
            string ID = "";
            int id = 0;
            if (formData.Keys.Contains("ID") && !string.IsNullOrEmpty(Convert.ToString(formData["ID"]))) { ID = Convert.ToString(formData["ID"]); id = int.Parse(ID);
                _order.Delete(id);
            }
          
            return Ok();
        }
        [Route("delete-product/{id}")]
        [HttpGet]
        public bool Delete(int id)
        {


            return _order.Delete(id);
        }
    }
}
