using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Productss : IProductss
    {
        private IProducts _res;
        public Productss(IProducts ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Product model)
        {
            return _res.Create(model);
        }
        public Product GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Product> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
