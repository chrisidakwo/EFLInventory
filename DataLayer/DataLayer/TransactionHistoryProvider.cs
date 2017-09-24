using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class TransactionHistoryProvider {
        public static int AddUpdateTransactionHistory(Transaction_History klass) {
            int _id = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (klass.id > 0) {
                    Transaction_History temp = db.Transaction_Histories.Where(u => u.id == klass.id).FirstOrDefault();
                    if (temp != null) {
                        temp.id = klass.id;
                        temp.dealer = klass.dealer;
                        temp.ProductVariationVariationID = klass.ProductVariationVariationID;
                        temp.quantity = klass.quantity;
                        temp.credit = klass.credit;
                        temp.debit = klass.debit;
                        temp.balance_due = klass.balance_due;
                        temp.change = klass.change;
                        temp.transaction_type = klass.transaction_type;
                        temp.payment_type = klass.payment_type;
                        temp.payment_date = klass.payment_date;
                        temp.remarks = klass.remarks;

                        db.Entry(temp).State = System.Data.EntityState.Modified;
                    }
                } else {
                    if (klass.payment_date.Date < DateTime.Now.Date) {
                        klass.payment_date = DateTime.Now.Date;
                    }
                    db.Transaction_Histories.Add(klass);
                }
                db.SaveChanges();
                _id = klass.id;
            }
            return _id;
        }

        public static bool AddBulkTransactionHistory(List<Transaction_History> lst_sellinghistory) {
            bool flag = false;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                foreach (Transaction_History item in lst_sellinghistory) {
                    db.Transaction_Histories.Add(item);
                }

                int x = db.SaveChanges();
                if (x > 0) {
                    flag = true;
                }
            }
            return flag;
        }

        public static decimal GetOverAllBalance(DateTime? StartDate, DateTime? EndDate) {
            decimal balance = 0.00M;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                try {
                    balance = (from s in db.Transaction_Histories
                               where (((s.payment_date >= StartDate) || (StartDate == null))
                               && ((s.payment_date <= EndDate) || (EndDate == null)))
                               select (s.credit - s.debit)).Sum();
                } catch { }
            }

            return balance;
        }

        public static TransactionPurchaseEntity GetPurchaseHistory(int Id) {
            TransactionPurchaseEntity purchaseHistory = new TransactionPurchaseEntity();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                purchaseHistory = (from t in db.Transaction_Histories
                                   join d in db.Dealers on t.dealer equals d.name
                                   join p in db.ProductVariations on t.ProductVariationVariationID equals p.VariationID
                                   where t.id == Id
                                   select new TransactionPurchaseEntity {
                                       ID = t.id,
                                       DealerName = d.name,
                                       ProductName = p.Product.name + " " + p.VariationName,
                                       Credit = t.credit,
                                       Quantity = t.quantity,
                                       BalanceDue = t.balance_due,
                                       Debit = t.debit,
                                       PaymentType = t.payment_type,
                                       Remarks = t.remarks,
                                       PaymentDate = t.payment_date,
                                   }).FirstOrDefault();
            }

            return purchaseHistory;
        }

        public static TransactionSellingEntity GetSellingHistory(int Id) {
            TransactionSellingEntity sellingHistory = new TransactionSellingEntity();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                sellingHistory = (from t in db.Transaction_Histories
                                  join v in db.ProductVariations on t.ProductVariationVariationID equals v.VariationID
                                  where t.id == Id
                                  select new TransactionSellingEntity {
                                      ID = t.id,
                                      ProductName = v.Product.name + " " + v.VariationName,
                                      Credit = t.credit,
                                      Quantity = t.quantity,
                                      BalanceDue = t.balance_due,
                                      Debit = t.debit,
                                      PaymentType = t.payment_type,
                                      Remarks = t.remarks,
                                      PaymentDate = t.payment_date,
                                      Change = t.change
                                  }).FirstOrDefault();
            }

            return sellingHistory;
        }

        public static List<TransactionPurchaseEntity> GetAllDebitTransaction(DateTime? StartDate, DateTime? EndDate) {
            List<TransactionPurchaseEntity> lsttxns = new List<TransactionPurchaseEntity>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                lsttxns = (from s in db.Transaction_Histories
                           join d in db.Dealers on s.dealer equals d.name
                           join p in db.ProductVariations on s.ProductVariationVariationID equals p.VariationID
                           where (((s.payment_date >= StartDate) || (StartDate == null))
                           && ((s.payment_date <= EndDate) || (EndDate == null)) && s.transaction_type == "Debit")
                           select new TransactionPurchaseEntity {
                               ID = s.id,
                               DealerName = d.name,
                               ProductName = p.Product.name + " " + p.VariationName,
                               Credit = s.credit,
                               Quantity = s.quantity,
                               BalanceDue = s.balance_due,
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
                lsttxns = (from s in db.Transaction_Histories
                           join v in db.ProductVariations on s.ProductVariationVariationID equals v.VariationID
                           where (((s.payment_date >= StartDate) || (StartDate == null))
                           && ((s.payment_date <= EndDate) || (EndDate == null)) && s.transaction_type == "Credit")
                           select new TransactionSellingEntity {
                               ID = s.id,
                               ProductName = v.Product.name + " " + v.VariationName,
                               Credit = s.credit,
                               Debit = s.debit,
                               Change = s.change,
                               BalanceDue = s.balance_due,
                               Quantity = s.quantity,
                               PaymentType = s.payment_type,
                               Remarks = s.remarks,
                               PaymentDate = s.payment_date
                           }).ToList();
            }
            return lsttxns;
        }

        public static List<PurchaseReportEntity> GetPurchaseReport(List<TransactionPurchaseEntity> data) {
            List<PurchaseReportEntity> _data = new List<PurchaseReportEntity>();
            List<string> productName = new List<string>();

            foreach (TransactionPurchaseEntity product in data) {
                if (!productName.Contains(product.ProductName)) {
                    productName.Add(product.ProductName);
                    PurchaseReportEntity entity = new PurchaseReportEntity() {
                        Dealer = product.DealerName,
                        ProductName = product.ProductName,
                        QuantityBought = product.Quantity,
                        Debit = product.Debit.Value,
                        BalanceDue = product.BalanceDue
                    };
                    _data.Add(entity);
                } else {
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().QuantityBought += product.Quantity;
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().Debit += product.Debit.Value;
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().BalanceDue += product.BalanceDue;
                }
            }

            return _data;
        }

        public static List<SalesReportEntity> GetSalesReport(List<TransactionSellingEntity> data) {
            List<SalesReportEntity> _data = new List<SalesReportEntity>();
            List<string> productName = new List<string>();

            foreach (TransactionSellingEntity product in data) {
                if (!productName.Contains(product.ProductName)) {
                    productName.Add(product.ProductName);
                    SalesReportEntity entity = new SalesReportEntity() {
                        ProductName = product.ProductName,
                        QuantitySold = product.Quantity,
                        Credit = product.Credit,
                        ChangeOwed = product.Change,
                        BalanceDue = product.BalanceDue
                    };
                    _data.Add(entity);
                } else {
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().QuantitySold += product.Quantity;
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().Credit += product.Credit;
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().ChangeOwed += product.Change;
                    _data.Where(d => d.ProductName == product.ProductName).FirstOrDefault().BalanceDue += product.BalanceDue;
                }
            }

            return _data;
        }
    }
}
