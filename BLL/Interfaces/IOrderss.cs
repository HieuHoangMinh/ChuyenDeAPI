using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IOrderss
    {
        bool Create(Order model);
        Order GetDatabyID(string id);
        List<Order> GetDataAll();

        //trangthai
        bool changeStatus(int id, string msg);

        //xem chi tiet
        List<OrderDetail> GetBillByID(string id);

        //xoa don hang
        bool Delete(int id);

    }
}
