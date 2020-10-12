using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IMenus
    {
        bool Create(Menu model);
        Menu GetDatabyID(string id);
        public List<Menu> GetDataAll();
    }
}
