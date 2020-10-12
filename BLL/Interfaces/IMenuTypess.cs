using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IMenuTypess
    {
        bool Create(MenuType model);
        MenuType GetDatabyID(string id);
        List<MenuType> GetDataAll();
    }
}
