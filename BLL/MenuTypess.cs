using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class MenuTypess : IMenuTypess
    {
        private IMenuTypes _res;
        public MenuTypess(IMenuTypes ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(MenuType model)
        {
            return _res.Create(model);
        }
        public MenuType GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<MenuType> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<MenuType> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
