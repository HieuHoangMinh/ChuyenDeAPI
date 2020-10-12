using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BLL.Interfaces
{
    public partial interface ICredentitalss
    {
        bool Create(Credentital model);
        Credentital GetDatabyID(string id);
        List<Credentital> GetDataAll();
    }
}
