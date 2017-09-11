//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.stock_threshold = 5;
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string image_url { get; set; }
        public string brand { get; set; }
        public int dealer_id { get; set; }
        public int Category_id { get; set; }
        public int subCategory_id { get; set; }
        public string weight { get; set; }
        public decimal cost_price { get; set; }
        public decimal sell_price { get; set; }
        public bool status { get; set; }
        public int stock_threshold { get; set; }
        public Nullable<int> Stock { get; set; }
        public System.DateTime date_created { get; set; }
        public Nullable<System.DateTime> last_updated { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Dealer Dealer { get; set; }
    }
}