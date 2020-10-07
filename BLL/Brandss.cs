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
        private IBrands Brand;
        public Brandss(IBrands Brand)
        {
            this.Brand = Brand;
        }
        public List<Brand> GetAll()
        {
            return Brand.GetData();
        }

    }
}
