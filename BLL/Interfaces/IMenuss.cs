using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IMenuss
    {
        bool Create(Menu model);
        Menu GetDatabyID(string id);
        List<Menu> GetDataAll();
    }
}
