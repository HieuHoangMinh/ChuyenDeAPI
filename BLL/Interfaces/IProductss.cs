﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IProductss
    {
        bool Create(Product model);
        Product GetDatabyID(int id);
        List<Product> GetDataAll();
        List<Product> GetByLoai(int page_index,
                                      int page_size,
                                       int category_id,out long total);
        List<Product> Search(int pageIndex, int pageSize, out long total, string Name, int? CategoryID);
    }
}
