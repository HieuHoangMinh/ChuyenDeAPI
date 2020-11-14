using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IOrders
    {
        bool Create(Order model);
        Order GetDatabyID(string id);
        public List<Order> GetDataAll();
        bool changeStatus(string id, string msg);
    }
}
