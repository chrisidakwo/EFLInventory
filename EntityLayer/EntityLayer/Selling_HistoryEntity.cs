namespace EntityLayer {
    public class Transaction_HistoryEntity {
        public int id { get; set; }
        public string dealer_name { get; set; }
        public string product_id { get; set; }
        public string quantity { get; set; }
        public string credit { get; set; }
        public string debit { get; set; }
        public int transaction_type_id { get; set; }
        public string customer_info { get; set; }
        public string payment_type { get; set; }
        public string payment_date { get; set; }
        public string customer_name { get; set; }
        public string remarks { get; set; }

        public virtual DealerEntity Dealer { get; set; }
        public virtual Transaction_TypeEntity Transaction_Type { get; set; }
    }
}