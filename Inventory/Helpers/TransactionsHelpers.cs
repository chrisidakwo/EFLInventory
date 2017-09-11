using BusinessLayer;
using DataLayer;
using EntityLayer;
using Inventory.Model;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Helpers {
    public class TransactionsHelpers {
        public static string OverAllBalance { get; set; }
        public static string MonthlyBalance { get; set; }
        public static string EmptyStockProductList { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static string GetOverAllBalance() {
            decimal oBalance = 0.00M;
            try {
                oBalance = SellingHistoryProvider.GetOverAllBalance(null, null);
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Background Task Error", "An error occurred while calculating overall balance!");
            }
            if (oBalance != 0.00M) {
                if (oBalance.ToString().Substring(0, 1) == "-") {
                    OverAllBalance = "-N" + string.Format("{0:#, ###0.#}", oBalance).Trim().Substring(1).Trim().Replace(" ", "");
                } else {
                    OverAllBalance = "N" + string.Format("{0:#, ###0.#}", oBalance).Trim().Replace(" ", "");
                }
            } else {
                OverAllBalance = "Error occured!";
            }
            Global.Get.InventoryBalance = OverAllBalance;

            return OverAllBalance;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="firstDayOfMonth"></param>
        /// <param name="lastDayOfMonth"></param>
        /// <returns></returns>
        public static string GetMonthBalance(DateTime firstDayOfMonth, DateTime lastDayOfMonth) {
            decimal mBalance = 0.00M;
            try {
                mBalance = SellingHistoryProvider.GetOverAllBalance(firstDayOfMonth, lastDayOfMonth);
            } catch (Exception) {
                ControlHelpers.ErrorNotification("Background Task Error", "An error occurred while calculating your balance for this month!");
            }
            if (mBalance != 0.00M) {
                if (mBalance.ToString().Substring(0, 1) == "-") {
                    MonthlyBalance = "-N" + string.Format("{0:#, ###0.#}", mBalance).Substring(1).Trim().Replace(" ", "");
                } else {
                    MonthlyBalance = "N" + string.Format("{0:#, ###0.#}", mBalance).Trim().Replace(" ", "");
                }
            } else {
                MonthlyBalance = "Error occured!";
            }

            return MonthlyBalance;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static string GetProductsWithEmptyStock() {
            var EmptyStockList = ProductServices.GetEmptyStockList();
            if (EmptyStockList.Count > 0) {
                foreach (Product _product in EmptyStockList) {
                    EmptyStockProductList += _product.name + ", ";
                }
            }

            if (EmptyStockProductList.Length > 0) {
                if (EmptyStockProductList.EndsWith(", ")) {
                    var newList = EmptyStockProductList.Remove(EmptyStockProductList.Length - 2);
                    EmptyStockProductList = newList + ".";
                }
            }

            return EmptyStockProductList;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="todayDate"></param>
        /// <returns></returns>
        public static string GetTotalSaleForToday(DateTime todayDate) {
            var t = "";
            var historyToday = new List<TransactionSellingEntity>();

            try {
                historyToday = SellingHistoryServices.GetAllCreditTransaction(todayDate, null);
            } catch (Exception) {
            }

            if (historyToday != null) {
                t = string.Format("{0:#, ###0.#}", Convert.ToDouble(historyToday.Sum(s => s.Credit.Value)));
                Global.Get.TotalSalesToday = "N" + t.Trim().Replace(" ", "");
            } else {
                t = "0";
            }

            return "N" + t.Trim().Replace(" ", "");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="firstDayOfMonth"></param>
        /// <param name="lastDayOfMonth"></param>
        /// <returns></returns>
        public static string GetTotalSalesForMonth(DateTime firstDayOfMonth, DateTime lastDayOfMonth) {
            var m = "";
            var historyMonth = new List<TransactionSellingEntity>();

            try {
                historyMonth = SellingHistoryServices.GetAllCreditTransaction(firstDayOfMonth, lastDayOfMonth);
            } catch (Exception) {
            }

            if (historyMonth != null) {
                m = string.Format("{0:#, ###0.#}", Convert.ToDouble(historyMonth.Sum(s => s.Credit.Value)));
                Global.Get.TotalSalesMonth = "N" + m.Trim().Replace(" ", "");
            } else {
                m = "0";
            }

            return "N" + m.Trim().Replace(" ", "");
        }

        public static string GetTotalSalesForHalfYear(DateTime todaysDate) {
            var halfYearStartMonth = 1;
            var halfYearEndMonth = 6;
            var year = todaysDate.Date.Year;

            var startdate = new DateTime(year, halfYearStartMonth, 1);
            var enddate = new DateTime(year, halfYearEndMonth, 30);

            if (todaysDate.Month > 6) {
                halfYearStartMonth = 7;
                halfYearEndMonth = 12;
                startdate = new DateTime(year, halfYearStartMonth, 1);
                enddate = new DateTime(year, halfYearEndMonth, 31);
            }

            var h = "";
            var historyHalfYear = new List<TransactionSellingEntity>();

            try {
                historyHalfYear = SellingHistoryServices.GetAllCreditTransaction(startdate, enddate);
            } catch (Exception) {
            }

            if (historyHalfYear != null) {
                h = string.Format("{0:#, ###0.#}", Convert.ToDouble(historyHalfYear.Sum(s => s.Credit.Value)));
                Global.Get.TotalSalesHalfYear = "N" + h.Trim().Replace(" ", "");
            } else {
                h = "0";
            }

            return "N" + h.Trim().Replace(" ", "");
        }

        public static string GetValueOfEntireStock() {
            decimal value = 0;
            var h = "";

            try {
                using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                    value = db.Products.Where(p => p.Stock > 0).Sum(p => p.cost_price);
                }
            } catch (Exception) {
            }

            if (value != 0.00M || value.ToString() != null || value.ToString() != "0") {
                h = string.Format("{0:#, ###0.#", value);
                Global.Get.InventoryValue = "N" + h.Trim().Replace(" ", "");
            } else {
                h = "0";
            }

            return "N" + h.Trim().Replace(" ", "");
        }
    }
}