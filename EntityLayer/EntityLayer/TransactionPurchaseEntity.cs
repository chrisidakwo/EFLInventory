using System;

namespace EntityLayer {
    public class TransactionPurchaseEntity {
        public int ID { get; set; }
        public string DealerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}