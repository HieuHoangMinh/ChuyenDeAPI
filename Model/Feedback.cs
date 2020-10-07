using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Feedback
    {
        public int ID{set;get;}
      public string Name{set;get;}
      public string Phone{set;get;}
      public string Email{set;get;}
      public string Address{set;get;}
      public string Content{set;get;}
      public DateTime CreatedDate{set;get;}
      public bool Status{set;get;}
    }
}
