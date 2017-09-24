using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer {
    public class TransactionHistoryServices {
        public static int AddUpdateTransactionHistory(Transaction_History klass) {
            return TransactionHistoryProvider.AddUpdateTransactionHistory(klass);
        }

        public static bool AddBulkTransactionHistory(List<Transaction_History> lst_sellinghistory) {
            return TransactionHistoryProvider.AddBulkTransactionHistory(lst_sellinghistory);
        }

        public static decimal GetOverAllBalance(DateTime? StartDate, DateTime? EndDate) {
            return TransactionHistoryProvider.GetOverAllBalance(StartDate, EndDate);
        }

        public static TransactionPurchaseEntity GetPurchaseHistory(int Id) {
            return TransactionHistoryProvider.GetPurchaseHistory(Id);
        }

        public static TransactionSellingEntity GetSellingHistory(int Id) {
            return TransactionHistoryProvider.GetSellingHistory(Id);
        }

        public static List<TransactionPurchaseEntity> GetAllDebitTransaction(DateTime? StartDate, DateTime? EndDate) {
            return TransactionHistoryProvider.GetAllDebitTransaction(StartDate, EndDate);
        }

        public static List<TransactionSellingEntity> GetAllCreditTransaction(DateTime? StartDate, DateTime? EndDate) {
            return TransactionHistoryProvider.GetAllCreditTransaction(StartDate, EndDate);
        }

        public static List<SalesReportEntity> GetSalesReport(List<TransactionSellingEntity> data) {
            return TransactionHistoryProvider.GetSalesReport(data);
        }

        public static List<PurchaseReportEntity> GetPurchaseReport(List<TransactionPurchaseEntity> data) {
            return TransactionHistoryProvider.GetPurchaseReport(data);
        }
    }
}
