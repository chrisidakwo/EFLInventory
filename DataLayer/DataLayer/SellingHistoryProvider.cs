using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class SellingHistoryProvider {
        public static int AddUpdateSellingHistory(Selling_History klass) {
            int _id = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (klass.id > 0) {
                    Selling_History temp = db.Selling_Histories.Where(u => u.id == klass.id).FirstOrDefault();
                    if (temp != null) {
                        temp.id = klass.id;
                        temp.dealer_id = klass.dealer_id;
                        temp.product_id = klass.product_id;
                        temp.quantity = klass.quantity;
                        temp.credit = klass.credit;
                        temp.debit = klass.debit;
                        temp.transaction_type_id = klass.transaction_type_id;
                        temp.customer_info = klass.customer_info;
                        temp.payment_type = klass.payment_type;
                        temp.payment_date = klass.payment_date;
                        temp.customer_name = klass.customer_name;
                        temp.remarks = klass.remarks;
                    }
                } else {
                    db.Selling_Histories.Add(klass);
                }
                db.SaveChanges();
                if (klass.id > 0) {
                    _id = klass.id;
                }
            }
            return _id;
        }

        public static bool AddBulkSellingHistory(List<Selling_History> lst_sellinghistory) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                foreach (Selling_History item in lst_sellinghistory) {
                    db.Selling_Histories.Add(item);
                }

                int x = db.SaveChanges();
                if (x > 0) {
                    flag = true;
                }
            }
            return flag;
        }

        public static decimal GetOverAllBalance(DateTime? StartDate, DateTime? EndDate) {
            decimal? balance = 0.00M;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                try {
                    balance = (from s in db.Selling_Histories
                               where (((s.payment_date >= StartDate) || (StartDate == null))
                               && ((s.payment_date <= EndDate) || (EndDate == null)))
                               select (s.credit - s.debit)).Sum();
                } catch { }
            }

            return Convert.ToDecimal(balance);
        }

        public static List<TransactionPurchaseEntity> GetAllDebitTransaction(DateTime? StartDate, DateTime? EndDate) {
            List<TransactionPurchaseEntity> lsttxns = new List<TransactionPurchaseEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                lsttxns = (from s in db.Selling_Histories
                           join d in db.Dealers on s.dealer_id equals d.id
                           join p in db.Products on s.product_id equals p.id
                           where (((s.payment_date >= StartDate) || (StartDate == null))
                           && ((s.payment_date <= EndDate) || (EndDate == null)) && s.transaction_type_id == 2)
                           select new TransactionPurchaseEntity {
                               ID = s.id,
                               DealerName = d.name,
                               ProductName = p.name,
                               Credit = s.credit,
                               Quantity = s.quantity,
                               Debit = s.debit,
                               PaymentType = s.payment_type,
                               Remarks = s.remarks,
                               PaymentDate = s.payment_date
                           }
                           ).ToList();
            }
            return lsttxns;
        }

        public static List<TransactionSellingEntity> GetAllCreditTransaction(DateTime? StartDate, DateTime? EndDate) {
            List<TransactionSellingEntity> lsttxns = new List<TransactionSellingEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                lsttxns = (from s in db.Selling_Histories
                           join p in db.Products on s.product_id equals p.id
                           where (((s.payment_date >= StartDate) || (StartDate == null))
                           && ((s.payment_date <= EndDate) || (EndDate == null)) && s.transaction_type_id == 1)
                           select new TransactionSellingEntity {
                               ID = s.id,
                               CustomerName = s.customer_name,
                               CustomerInfo = s.customer_info,
                               ProductName = p.name,
                               Credit = s.credit,
                               Debit = s.debit,
                               Quantity = s.quantity,
                               PaymentType = s.payment_type,
                               Remarks = s.remarks,
                               PaymentDate = s.payment_date
                           }).ToList();
            }
            return lsttxns;
        }
    }
}