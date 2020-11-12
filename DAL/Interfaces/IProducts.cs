using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProducts
    {
        bool Create(Product model);
        Product GetDatabyID(int id);
        public List<Product> GetDataAll();
        List<Product> GetByLoai(int page_index,
                                       int page_size,
                                        int category_id,out long total);
        List<Product> Search(int pageIndex, int pageSize, out long total, string Name, int? CategoryID);
        bool Update(Product model);
        bool Delete(int ID);
        List<Product> GetProductRelated(int id, int category_id);
    }
}
