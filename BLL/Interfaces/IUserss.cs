using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IUserss
    {
        bool Create(User model);
        User GetDatabyID(string id);
        List<User> GetDataAll();
    }
}
