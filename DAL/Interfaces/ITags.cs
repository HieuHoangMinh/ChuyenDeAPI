using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ITags
    {
        bool Create(Tag model);
        Tag GetDatabyID(string id);
        public List<Tag> GetDataAll();
    }
}
