using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IProductss
    {
        bool Create(Product model);
        Product GetDatabyID(string id);
        List<Product> GetDataAll();
    }
}
