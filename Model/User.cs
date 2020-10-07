using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User
    {
        public int  ID{set;get;}
      public string UserName{set;get;}
      public string PassWord{set;get;}
      public string GroupID{set;get;}
      public string Name{set;get;}
      public string Address{set;get;}
      public string Email{set;get;}
      public string Phone{set;get;}
      public DateTime CreatedDate{set;get;}
      public string CreatedBy{set;get;}
      public string ModifiedDate{set;get;}
      public string ModifiedBy{set;get;}
      public bool Status{set;get;}
    }
}
