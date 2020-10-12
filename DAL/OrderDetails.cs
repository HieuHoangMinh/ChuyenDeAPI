using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class OrderDetails : IOrderDetails
    {
        private IDatabaseHelper _dbHelper;
        public OrderDetails(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<OrderDetail> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_orderdetail_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<OrderDetail>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(OrderDetail model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_orderdetail_create",
                "@ProductID", model.ProductID,
                "@OrderID", model.OrderID,
                "@Quantity", model.Quantity,
                "@Price", model.Price);
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
        public OrderDetail GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_orderdetail_get_by_id",
                     "@ProductID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<OrderDetail>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OrderDetail> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
