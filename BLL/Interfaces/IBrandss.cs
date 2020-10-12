using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IBrandss
    {
        bool Create(Brand model);
        Brand GetDatabyID(string id);
        List<Brand> GetDataAll();
    }
}
