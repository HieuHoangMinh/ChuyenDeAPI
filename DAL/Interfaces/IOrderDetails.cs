using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IOrderDetails
    {
        bool Create(OrderDetail model);
        OrderDetail GetDatabyID(string id);
        public List<OrderDetail> GetDataAll();
    }
}
