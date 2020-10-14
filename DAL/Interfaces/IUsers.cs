using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUsers
    {
        bool Create(User model);
        User GetDatabyID(string id);
        public List<User> GetDataAll();
    }
}
