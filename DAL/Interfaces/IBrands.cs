using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IBrands
    {
        bool Create(Brand model);
        Brand GetDatabyID(string id);
        public List<Brand> GetDataAll();
    }
}
