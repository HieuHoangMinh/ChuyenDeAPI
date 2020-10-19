﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface IRoless
    {
        bool Create(Role model);
        Role GetDatabyID(string id);
        List<Role> GetDataAll();
    }
}