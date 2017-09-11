using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer {
    public class SellingHistoryServices {
        public static int AddUpdateSellingHistory(Selling_History klass) {
            return SellingHistoryProvider.AddUpdateSellingHistory(klass);
        }

        public static bool AddBulkSellingHistory(List<Selling_History> lst_sellinghistory) {
            return SellingHistoryProvider.AddBulkSellingHistory(lst_sellinghistory);
        }

        public static decimal GetOverAllBalance(DateTime? StartDate, DateTime? EndDate) {
            return SellingHistoryProvider.GetOverAllBalance(StartDate, EndDate);
        }

        public static List<TransactionPurchaseEntity> GetAllDebitTransaction(DateTime? StartDate, DateTime? EndDate) {
            return SellingHistoryProvider.GetAllDebitTransaction(StartDate, EndDate);
        }

        public static List<TransactionSellingEntity> GetAllCreditTransaction(DateTime? StartDate, DateTime? EndDate) {
            return SellingHistoryProvider.GetAllCreditTransaction(StartDate, EndDate);
        }
    }
}