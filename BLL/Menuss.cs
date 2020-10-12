using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Menuss : IMenuss
    {
        private IMenus _res;
        public Menuss(IMenus ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Menu model)
        {
            return _res.Create(model);
        }
        public Menu GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Menu> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Menu> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
