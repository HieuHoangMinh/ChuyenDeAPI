﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IOrderDetailss
    {
        bool Create(Model.OrderDetail model);
        OrderDetail GetDatabyID(string id);
        List<OrderDetail> GetDataAll();
    }
}
