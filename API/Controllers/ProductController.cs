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

        public ResponseModel Search([FromBody] Dictionary<string, object> formData)
        {
            var response = new ResponseModel();
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string Name = "";
                if (formData.Keys.Contains("Name") && !string.IsNullOrEmpty(Convert.ToString(formData["Name"]))) { Name = Convert.ToString(formData["Name"]); }
                string CategoryID = "";
                if (formData.Keys.Contains("CategoryID") && !string.IsNullOrEmpty(Convert.ToString(formData["CategoryID"]))) { CategoryID = Convert.ToString(formData["CategoryID"]); }
                long total = 0;
                var data = _order.Search(page, pageSize, out total, Name, CategoryID);
                response.TotalItems = total;
                response.Data = data;
                response.Page = page;
                response.PageSize = pageSize;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return response;
        }
    }
}
