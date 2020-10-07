using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Brands : IBrands
    {
        private IDatabaseHelper _dbHelper;
        public Brands(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<Brand> GetData()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, " brand_get_data");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<Brand>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}