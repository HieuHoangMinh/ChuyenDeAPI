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
    }
}
