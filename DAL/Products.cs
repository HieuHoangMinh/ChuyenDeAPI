using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Products : IProducts
    {
        private IDatabaseHelper _dbHelper;
        public Products(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<Product> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_product_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<Product>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(Product model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_product_create",
                "@ID", model.ID,
                "@Name", model.Name,
                "@Code", model.Code,
                "@MetaTitle", model.MetaTitle,
                "@Description", model.Description,
                "@image", model.image,
                "@MoreImages", model.MoreImages,
                "@Price", model.Price,
                "@PromotionPrice", model.PromotionPrice,
                "@IncludedVAT", model.IncludedVAT,
                "@Quantity", model.Quantity,
                "@CategoryID", model.CategoryID,
                "@Detail", model.Detail,
                "@Warranty", model.Warranty,
                "@CreatedDate", model.CreatedDate,
                "@CreatedBy", model.CreatedBy,
                "@ModifiedDate", model.ModifiedDate,
                "@ModifiedBy", model.ModifiedBy,
                "@MetaKeywords", model.MetaKeywords,
                "@MetaDescriptions", model.MetaDescriptions,
                "@Status", model.Status,
                "@TopHot", model.TopHot,
                "@ViewCount", model.Status);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //laythuonghieu theo ID
        public Product GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_product_get_by_id",
                     "@ID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<Product>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
