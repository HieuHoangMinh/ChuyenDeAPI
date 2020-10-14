using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class Users : IUsers
    {
        private IDatabaseHelper _dbHelper;
        public Users(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<User> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_user_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<User>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(User model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_user_create",
                 "@ID",
                 "@UserName",model.UserName,
                 "@PassWord",model.PassWord,
                 "@GroupID",model.GroupID,
                 "@Name",model.Name,
                 "@Address",model.Address,
                 "@Email",model.Email,
                 "@Phone",model.Phone,
                 "@CreatedDate",model.CreatedDate,
                 "@CreatedBy",model.CreatedBy,
                 "@ModifiedDate",model.ModifiedDate,
                 "@ModifiedBy",model.ModifiedBy,
                 "@Status", model.Status);
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
        public User GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_user_get_by_id",
                     "@ID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<User>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
