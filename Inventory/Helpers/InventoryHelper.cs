using System;
using System.ComponentModel;
using System.IO;

namespace Inventory.Helpers {
    public class InventoryHelper {
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
            Transfer = 4,
            [Description("For Home Use")]
            HomeUse = 5
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
