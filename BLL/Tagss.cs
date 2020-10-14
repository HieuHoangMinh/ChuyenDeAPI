using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Tagss : ITagss
    {
        private ITags _res;
        public Tagss(ITags ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(Tag model)
        {
            return _res.Create(model);
        }
        public Tag GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<Tag> GetDataAll()
        {
            return _res.GetDataAll();
        }

        public List<Tag> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
