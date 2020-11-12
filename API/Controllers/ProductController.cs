using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductss _order;
        private string _path;
        public ProductController(IProductss itemBusiness, IConfiguration configuration)
        {
            _order = itemBusiness;
            _path = configuration["AppSettings:PATH"];
        }

        public string SaveFileFromBase64String(string RelativePathFileName, string dataFromBase64String)
        {
            if (dataFromBase64String.Contains("base64,"))
            {
                dataFromBase64String = dataFromBase64String.Substring(dataFromBase64String.IndexOf("base64,", 0) + 7);
            }
            return WriteFileToAuthAccessFolder(RelativePathFileName, dataFromBase64String);
        }

        public string WriteFileToAuthAccessFolder(string RelativePathFileName, string base64StringData)
        {
            try
            {
                string result = "";
                string serverRootPathFolder = _path;
                string fullPathFile = $@"{serverRootPathFolder}\{RelativePathFileName}";
                string fullPathFolder = System.IO.Path.GetDirectoryName(fullPathFile);
                if (!Directory.Exists(fullPathFolder))
                    Directory.CreateDirectory(fullPathFolder);
                System.IO.File.WriteAllBytes(fullPathFile, Convert.FromBase64String(base64StringData));
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [Route("create-item")]
        [HttpPost]
        public Model.Product CreateItem([FromBody] Product model)
        {
            if (model.image != null)
            {
                var arrData = model.image.Split(';');
                if (arrData.Length == 3)
                {
                    var savePath = $@"{arrData[0]}";
                    model.image = $"{savePath}";
                    SaveFileFromBase64String(savePath, arrData[2]);
                }
            }
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
        [Route("get-item-related/{id}/{category_id}")]
        [HttpGet]
        public IEnumerable<Product> GetProductRelated(int id, int category_id)
        {
            return _order.GetProductRelated(id, category_id);
        }
    }
}
