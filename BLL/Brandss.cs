using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public  class Brandss : IBrandss
    {
        private IBrands _res;
        public Brandss(IBrands ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Brand model)
        {
            return _res.Create(model);
        }
        public Brand GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Brand> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
