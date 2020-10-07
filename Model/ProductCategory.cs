using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ProductCategory
    {
        public int ID { set; get; }
        public string Name {get;set;}
      public string MetaTitle {get;set;}
      public int ParenID {get;set;}
      public int DisplayOder {get;set;}
      public string SeoTitle {get;set;}
      public DateTime CreatedDate {get;set;}
      public string CreatedBy {get;set;}
      public DateTime ModifiedDate {get;set;}
      public string ModifiedBy {get;set;}
      public string MetaKeywords {get;set;}
      public string MetaDescriptions {get;set;}
      public bool Status {get;set;}
      public bool ShowOnHome {get;set;}
    }
}
