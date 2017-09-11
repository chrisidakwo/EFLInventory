using System;
using System.ComponentModel;
using System.IO;

namespace Inventory.Helpers {
    public class InventoryHelper {
        #region MenuTitle
        public static string SubCategory = "Sub Category";
        public static string Category = "Category";
        public static string AddDealer = "Add Dealers";
        public static string ModifyDealer = "Modify Dealer";
        public static string AddProduct = "Add Product";
        public static string ModifyProduct = "Modify Products";
        public static string StockEntry = "Stock Entry";
        public static string SellProducts = "Sell Products";
        public static string Transactions = "Transactions";
        public static string InventorySummary = "Inventory Summary";
        public static string GenerateReport = "Generate Report";
        #endregion MenuTitle

        #region Icons
        public static string SubCategoryIcon = "/Files/SubCategory.png";
        public static string CategoryIcon = "/Files/category.png";
        public static string AddDealerIcon = "/Files/dealer.jpg";
        public static string ModifyDealerIcon = "/Files/ModifyDealer.jpg";
        public static string AddProductIcon = "/Files/AddProduct.png";
        public static string ModifyProductIcon = "/Files/ModifyProduct.png";
        public static string StockEntryIcon = "/Files/StockEntry.png";
        public static string SellProductsIcon = "/Files/sellproducts.png";
        public static string TransactionsIcon = "/Files/Transaction.jpg";
        public static string InventoryIcon = "Files/Inventory.jpg";
        public static string ReportIcon = "Files/GenerateReport.jpg";
        #endregion Icons

        public static string ImageNA = "/Files/NA.png";

        public static string GetSaveFilePath() {
            string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string FolderName = "EFL Inventory";
            DirectoryPath += @"\" + FolderName;
            if (!Directory.Exists(DirectoryPath)) {
                Directory.CreateDirectory(DirectoryPath);
            }
            return DirectoryPath;
        }

        public enum TransactionType {
            Credit = 1,
            Debit = 2
        }

        public enum PaymentType {
            [Description("Cash Payment")]
            Cash = 1,
            [Description("Cheque Payment")]
            Cheque = 2,
            [Description("POS Payment")]
            POS = 3,
            [Description("Bank Transfer")]
            Transfer = 4
        }

        public enum SortChoices {
            [Description("Name")]
            Name = 0,
            [Description("Brand")]
            Brand = 1,
            [Description("Category")]
            Category = 2,
            [Description("SubCategory")]
            SubCategory = 3,
            [Description("Stock")]
            Stock = 4,
            [Description("Sale Price")]
            SalePrice = 5
        }

        public enum SortOrder {
            [Description("Ascending")]
            Ascending = 0,
            [Description("Descending")]
            Descending = 1
        }

        public static DateTime GetFirstDateOfWeek(DateTime dayInWeek, DayOfWeek RunningDay)  //RunningDay is Schedular Running day
        {
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != RunningDay)
                firstDayInWeek = firstDayInWeek.AddDays(-1);

            return firstDayInWeek;
        }

        public static DateTime GetLastDateOfWeek(DateTime dayInWeek, DayOfWeek RunningDay) {
            DateTime lastDayInWeek = dayInWeek.Date;
            while (lastDayInWeek.DayOfWeek != RunningDay)
                lastDayInWeek = lastDayInWeek.AddDays(1);

            return lastDayInWeek;
        }

        public static DateTime GetLastDayOfMonth() {
            DateTime firstOfNextMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1);
            DateTime lastOfThisMonth = firstOfNextMonth.AddDays(-1);
            return lastOfThisMonth;
        }

        public static DateTime GetLastWeekdayOfMonth(DateTime date, DayOfWeek day)         // Get last WeekdayofMonth according to day
        {
            DateTime lastDayOfMonth = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
            int wantedDay = (int)day;
            int lastDay = (int)lastDayOfMonth.DayOfWeek;
            return lastDayOfMonth.AddDays(lastDay >= wantedDay ? wantedDay - lastDay : wantedDay - lastDay - 7);
        }

        public static DateTime GetMonthFirstday(DateTime date) {
            DateTime FirstDay = new DateTime(date.Year, date.Month, 1);
            return FirstDay;
        }

        public static DateTime GetMonthLastday(DateTime date) {
            DateTime firstDayOfTheMonth = new DateTime(date.Year, date.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public static bool CheckWeekEndDay() {
            DateTime currentdate = DateTime.Now.Date;
            DateTime lastDayInWeek = GetLastDateOfWeek(DateTime.Now, DayOfWeek.Sunday);
            if (currentdate == lastDayInWeek) {
                return true;
            } else {
                return false;
            }
        }

        public static bool CheckMonthWeekEndDay() {
            DateTime currentdate = DateTime.Now.Date;
            DateTime monthlastweekend = GetLastWeekdayOfMonth(DateTime.Now, DayOfWeek.Sunday);
            if (currentdate == monthlastweekend) {
                return true;
            } else {
                return false;
            }
        }

        public static string DynamicConnectionString {
            get {
                return @"metadata=res://*/EFLInventory.csdl|res://*/EFLInventory.ssdl|res://*/EFLInventory.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + ServerConnection.Default.ServerName + ";initial catalog=" + ServerConnection.Default.DatabaseName + ";user id=" + ServerConnection.Default.UserName + ";password=" + ServerConnection.Default.Password + ";MultipleActiveResultSets=True;App=EntityFramework';";
            }
        }
    }
}