using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProductCategoryss : IProductCategoryss
    {
        private IProductCategorys _res;
        public ProductCategoryss(IProductCategorys ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(ProductCategory model)
        {
            return _res.Create(model);
        }
        public ProductCategory GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<ProductCategory> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<ProductCategory> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
