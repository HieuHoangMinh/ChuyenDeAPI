using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Userss : IUserss
    {
        private IUsers _res;
        public Userss(IUsers ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(User model)
        {
            return _res.Create(model);
        }
        public User GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<User> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
