using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Feedbackss : IFeedbackss
    {
        private IFeedbacks _res;
        public Feedbackss(IFeedbacks ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Feedback model)
        {
            return _res.Create(model);
        }
        public Feedback GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Feedback> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Feedback> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
