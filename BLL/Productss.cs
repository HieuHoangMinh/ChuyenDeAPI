﻿using BLL.Interfaces;
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
        public bool Update(Product model)
        {
            return _res.Update(model);
        }
        public Product GetDatabyID(int id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Product> GetDataAll()
        {
            return _res.GetDataAll();
        }
       public List<Product> GetByLoai(int page_index,
                                       int page_size,
                                        int category_id,out long total)
        {
            return _res.GetByLoai(page_index, page_size, category_id,out total);
        }
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Product> Search(int pageIndex, int pageSize, out long total, string Name, int? CategoryID)
        {
            return _res.Search(pageIndex, pageSize, out total, Name, CategoryID);
        }
        public bool Delete(int ID)
        {
            return _res.Delete(ID);
        }
        public List<Product> GetProductRelated(int id, int category_id)
        {
            return _res.GetProductRelated(id, category_id);
        }

    }
}
