using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Order
    {
        public int ID{set;get;}
      public DateTime CreateDate{set;get;}
      public int CustomerID{set;get;}
      public string ShipName{set;get;}
      public string ShipMobile{set;get;}
      public string ShipAddress{set;get;}
      public string ShipEmail{set;get;}
      public bool Status{set;get;}
    }
}
