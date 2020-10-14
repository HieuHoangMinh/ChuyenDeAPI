using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Roless : IRoless
    {
        private IRoles _res;
        public Roless(IRoles ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Role model)
        {
            return _res.Create(model);
        }
        public Role GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Role> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
