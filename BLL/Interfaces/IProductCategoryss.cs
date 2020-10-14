using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IProductCategoryss
    {
        bool Create(ProductCategory model);
        ProductCategory GetDatabyID(string id);
        List<ProductCategory> GetDataAll();
    }
}
