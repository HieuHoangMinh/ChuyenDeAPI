using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProductCategorys
    {
        bool Create(ProductCategory model);
        ProductCategory GetDatabyID(string id);
        public List<ProductCategory> GetDataAll();
    }
}
