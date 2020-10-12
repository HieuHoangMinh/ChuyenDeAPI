using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IFeedbacks
    {
        bool Create(Feedback model);
        Feedback GetDatabyID(string id);
        public List<Feedback> GetDataAll();
    }
}
