using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UserGroupss : IUserGroupss
    {
        private IUserGroups _res;
        public UserGroupss(IUserGroups ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(UserGroup model)
        {
            return _res.Create(model);
        }
        public UserGroup GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<UserGroup> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<UserGroup> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
