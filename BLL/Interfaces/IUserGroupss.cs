using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IUserGroupss
    {
        bool Create(UserGroup model);
        UserGroup GetDatabyID(string id);
        List<UserGroup> GetDataAll();
    }
}
