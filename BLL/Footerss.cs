using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Footerss : IFooterss
    {
        private IFooters _res;
        public Footerss(IFooters ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Footer model)
        {
            return _res.Create(model);
        }
        public Footer GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Footer> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Footer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
