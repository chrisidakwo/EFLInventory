namespace EntityLayer {
    public class ProductEntity {
        public int id { get; set; }
        public string name { get; set; }
        public string image_url { get; set; }
        public string brand { get; set; }
        public int dealer_id { get; set; }
        public string category_name { get; set; }
        public int category_id { get; set; }
        public string subcategory_name { get; set; }
        public int subcategory_id { get; set; }
        public string weight { get; set; }
        public decimal cost_price { get; set; }
        public decimal sell_price { get; set; }
        public bool status { get; set; }
        public int? Stock { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual SubCategoryEntity SubCategory { get; set; }
        public virtual DealerEntity Dealer { get; set; }
    }
}