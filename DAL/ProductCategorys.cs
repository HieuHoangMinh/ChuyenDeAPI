using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class ProductCategorys : IProductCategorys
    {
        private IDatabaseHelper _dbHelper;
        public ProductCategorys(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<ProductCategory> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_productcategory_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ProductCategory>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(ProductCategory model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_productcategory_create",
                 "@ID", model.ID,
                 "@Name", model.Name,
                 "@MetaTitle", model.MetaTitle,
                 "@ParenID", model.ParenID,
                 "@DisplayOder", model.DisplayOder,
                 "@SeoTitle", model.SeoTitle,
                 "@CreatedDate", model.CreatedDate,
                 "@CreatedBy", model.CreatedBy,
                 "@ModifiedDate", model.ModifiedDate,
                 "@ModifiedBy", model.ModifiedBy,
                 "@MetaKeywords", model.MetaKeywords,
                 "@MetaDescriptions", model.MetaDescriptions,
                 "@Status", model.Status,
                 "@ShowOnHome", model.ShowOnHome);
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
        public ProductCategory GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_productcategory_get_by_id",
                     "@ID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ProductCategory>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductCategory> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
