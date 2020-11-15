using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Orderss : IOrderss
    {
        private IOrders _res;
        public Orderss(IOrders ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Order model)
        {
            return _res.Create(model);
        }
        public Order GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Order> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        //trang thai
        public bool changeStatus(int id, string msg)
        {
            return _res.changeStatus(id, msg);
        }

        //xem chi tiet
        public List<OrderDetail> GetBillByID(string id)
        {
            return _res.GetBillByID(id);
        }

        //xoa don hang
        public bool Delete(int id)
        {
            return _res.Delete(id);
        }
    }
}
