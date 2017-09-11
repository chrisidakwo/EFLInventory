using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class TransactionTypeServices {
        public static List<Transaction_Type> GetAllTransactionTypes() {
            return TransactionTypeProvider.GetAllTransactionTypes();
        }
    }
}