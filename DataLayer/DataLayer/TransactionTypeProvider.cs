using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class TransactionTypeProvider {
        public static List<Transaction_Type> GetAllTransactionTypes() {
            List<Transaction_Type> tt = new List<Transaction_Type>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                tt = db.Transaction_Types.OrderBy(t => t.type).ToList();
            }
            return tt;
        }
    }
}