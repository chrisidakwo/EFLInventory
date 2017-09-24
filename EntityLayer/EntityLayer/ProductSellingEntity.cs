using System;

namespace EntityLayer {
    public class ProductSellingEntity {
        public int ProductId { get; set; }
        public Guid VariationId { get; set; }
        public string ProductName { get; set; }
        public string VariationName { get; set; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public bool Wholesale { get; set; }
        public decimal Amount { get; set; }
    }
}
