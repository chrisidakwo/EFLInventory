using System;

namespace EntityLayer {
    public class ProductEntity {
        public int id { get; set; }
        public string name { get; set; }
        public string Variations { get; set; }
        public string BrandName { get; set; }
        public int BrandID { get; set; }
        public string DealerName { get; set; }
        public int DealerID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public bool status { get; set; }
        public DateTime date_created { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class ProductVariationEntity {
        public Guid VariationID { get; set; }
        public string ProductName { get; set; }
        public string VariationName { get; set; }
        public int ProductID { get; set; }
        public string BrandName { get; set; }
        public int BrandID { get; set; }
        public string DealerName { get; set; }
        public int DealerID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public bool status { get; set; }
        public string image_url { get; set; }
        public string measured_by { get; set; }
        public int MeasuringTypeID { get; set; }
        public decimal weight { get; set; }
        public decimal cost_price { get; set; }
        public decimal retail_price { get; set; }
        public decimal wholesale_price { get; set; }
        public int stock_threshold { get; set; }
        public int stock { get; set; }
        public DateTime? expiry_date { get; set; }
    }
}
