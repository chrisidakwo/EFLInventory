using System;

namespace EntityLayer {
    public class InventorySummaryEntity {
        public int productID { get; set; }
        public Guid VariationID { get; set; }
        public string VariationName { get; set; }
        public int availableStock { get; set; }
        public string unit_measurement { get; set; }
        public double retailPrice { get; set; }
        public double wholesalePrice { get; set; }
        public double totalSales { get; set; }
    }
}
