using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IFooterss
    {
        bool Create(Footer model);
        Footer GetDatabyID(string id);
        List<Footer> GetDataAll();
    }
}
