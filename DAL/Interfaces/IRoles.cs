using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRoles
    {
        bool Create(Role model);
        Role GetDatabyID(string id);
        public List<Role> GetDataAll();
    }
}
