using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Credentitalss : ICredentitalss
    {
        private ICredentitals _res;
        public Credentitalss(ICredentitals ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Credentital model)
        {
            return _res.Create(model);
        }
        public Credentital GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Credentital> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Credentital> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
