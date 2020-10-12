using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class OrderDetailss : IOrderDetailss
    {
        private IOrderDetails _res;
        public OrderDetailss(IOrderDetails ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(OrderDetail model)
        {
            return _res.Create(model);
        }
        public OrderDetail GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<OrderDetail> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<OrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
