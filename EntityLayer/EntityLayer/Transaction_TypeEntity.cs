using System.Collections.Generic;

namespace EntityLayer {
    public class Transaction_TypeEntity {
        public Transaction_TypeEntity() {
            Selling_History = new HashSet<Selling_HistoryEntity>();
        }

        public int id { get; set; }
        public string type { get; set; }

        public virtual ICollection<Selling_HistoryEntity> Selling_History { get; set; }
    }
}