using System.Collections.Generic;

namespace EntityLayer {
    public class Transaction_TypeEntity {
        public Transaction_TypeEntity() {
            Transaction_History = new HashSet<Transaction_HistoryEntity>();
        }

        public int id { get; set; }
        public string type { get; set; }

        public virtual ICollection<Transaction_HistoryEntity> Transaction_History { get; set; }
    }
}