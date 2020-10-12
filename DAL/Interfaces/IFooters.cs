using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IFooters
    {
        bool Create(Footer model);
        Footer GetDatabyID(string id);
        public List<Footer> GetDataAll();
    }
}
