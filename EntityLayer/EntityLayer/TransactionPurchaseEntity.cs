using System;

namespace EntityLayer {
    public class TransactionPurchaseEntity {
        public TransactionPurchaseEntity() {
            BalanceDue = 0.00m;
        }
        public int ID { get; set; }
        public string DealerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public decimal BalanceDue { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public class PurchaseReportEntity {
        public string ProductName { get; set; }
        public string Dealer { get; set; }
        public int QuantityBought { get; set; }
        public decimal? Debit { get; set; }
        public decimal BalanceDue { get; set; }
    }
}
