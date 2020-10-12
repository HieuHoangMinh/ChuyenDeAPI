using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interfaces
{
    public interface ICredentitals
    {
        bool Create(Credentital model);
        Credentital GetDatabyID(string id);
        public List<Credentital> GetDataAll();
    }
}
