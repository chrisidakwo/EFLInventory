using System;

namespace EntityLayer {
    public class TransactionSellingEntity {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal Change { get; set; }
        public decimal BalanceDue { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    public class SalesReportEntity {
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public decimal? Credit { get; set; }
        public decimal ChangeOwed { get; set; }
        public decimal BalanceDue { get; set; }
    }
}
