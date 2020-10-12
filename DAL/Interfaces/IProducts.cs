using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProducts
    {
        bool Create(Product model);
        Product GetDatabyID(string id);
        public List<Product> GetDataAll();
    }
}
