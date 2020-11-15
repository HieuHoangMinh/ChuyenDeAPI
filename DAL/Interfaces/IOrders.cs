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

        //xac thuc don hang
        bool changeStatus(int id, string msg);

        //xemchitietdonhang
        List<OrderDetail> GetBillByID(string id);

        //xóa đơn hàng
        bool Delete(int id);

    }
}
