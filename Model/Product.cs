using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Product
    {
        public int ID{set;get;}
      public string Name{set;get;}
      public string Code{set;get;}
      public string MetaTitle{set;get;}
      public string Description{set;get;}
      public string image{set;get;}
      public decimal Price{set;get;}
      public decimal PromotionPrice{set;get;}
      public bool IncludedVAT{set;get;}
      public int Quantity{set;get;}
      public int CategoryID{set;get;}
      public string Detail{set;get;}
      public int Warranty{set;get;}
      public DateTime CreatedDate{set;get;}
      public string CreatedBy{set;get;}
      public DateTime ModifiedDate{set;get;}
      public string ModifiedBy{set;get;}
      public string MetaKeywords{set;get;}
      public string MetaDescriptions{set;get;}
      public bool Status{set;get;}
      public DateTime TopHot{set;get;}
      public int ViewCount{set;get;}
    }
}
