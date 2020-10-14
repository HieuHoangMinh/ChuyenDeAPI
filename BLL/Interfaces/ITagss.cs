using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public partial interface ITagss
    {
        bool Create(Tag model);
        Tag GetDatabyID(string id);
        List<Tag> GetDataAll();
    }
}
