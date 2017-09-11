namespace EntityLayer {
    public class InventorySummaryEntity {
        public int productID { get; set; }
        public string productName { get; set; }
        public int? availableStock { get; set; }
        public double totalSales { get; set; }
        public double purchasedPrice { get; set; }
    }
}