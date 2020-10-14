using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class UserGroups : IUserGroups
    {
        private IDatabaseHelper _dbHelper;
        public UserGroups(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<UserGroup> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_usergroup_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<UserGroup>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(UserGroup model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_usergroup_create",
                 "@ID",
                 "@Name", model.Name);
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
        public UserGroup GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_usergroup_get_by_id",
                     "@ID", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<UserGroup>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserGroup> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
