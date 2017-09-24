using System.Collections.Generic;

namespace EntityLayer {
    public class DealerEntity {
        public DealerEntity() {
            Transaction_History = new HashSet<Transaction_HistoryEntity>();
            Products = new HashSet<ProductEntity>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int brand_id { get; set; }
        public string products { get; set; }

        public virtual ICollection<Transaction_HistoryEntity> Transaction_History { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
