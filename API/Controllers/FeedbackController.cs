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
    public class FeedbackController : ControllerBase
    {
        private IFeedbackss _feedback;
        public FeedbackController(IFeedbackss itemBusiness)
        {
            _feedback = itemBusiness;
        }

        [Route("create-item")]
        [HttpPost]
        public Feedback CreateItem([FromBody] Feedback model)
        {
            _feedback.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public Feedback GetDatabyID(string id)
        {
            return _feedback.GetDatabyID(id);
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<Feedback> GetDatabAll()
        {
            return _feedback.GetDataAll();
        }
    }
}
