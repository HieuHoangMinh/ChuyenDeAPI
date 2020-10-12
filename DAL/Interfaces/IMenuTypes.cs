using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IMenuTypes
    {
        bool Create(MenuType model);
        MenuType GetDatabyID(string id);
        public List<MenuType> GetDataAll();
    }
}
