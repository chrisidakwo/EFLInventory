using System.Collections.Generic;

namespace EntityLayer {
    public class DealerEntity {
        public DealerEntity() {
            Selling_History = new HashSet<Selling_HistoryEntity>();
            Products = new HashSet<ProductEntity>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string products { get; set; }

        public virtual ICollection<Selling_HistoryEntity> Selling_History { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}