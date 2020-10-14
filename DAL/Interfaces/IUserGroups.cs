using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUserGroups
    {
        bool Create(UserGroup model);
        UserGroup GetDatabyID(string id);
        public List<UserGroup> GetDataAll();
    }
}
