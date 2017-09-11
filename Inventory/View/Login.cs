using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.View {
    public partial class Login : KryptonForm {
        private readonly BackgroundWorker worker = new BackgroundWorker();
        private string OverAllBalance = "Error occured!";
        private string MonthlyBalance = "Error occured!";
        private string EmptyStockProductList = "";
        public Login() {
            InitializeComponent();
            int users = 0;
            try {
                users = UserServices.GetAllUsers().Where(u => u.is_superuser = true).Count();
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, "Not Authenticated", "Loading login page. Trying to retrieve a list of users from db.");
            }

            if (users >= 2) {
                lblUserAcctConfig.Visible = false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public bool UserLogin(string username, string password) {
            bool successful = false;
            try {
                bool flag = UserServices.CheckLogin(username, password);
                if (flag == true) {
                    worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                    worker.RunWorkerAsync();

                    LoginCredentials.username = UserServices.GetUserByUsername(username).username;
                    LoginCredentials.userid = UserServices.GetUserByUsername(username).id;
                    successful = true;
                } else {
                    string message = "Invalid email or password. Please provide valid credentials!";
                    KryptonMessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                var name = "";
                if (LoginCredentials.username == "")
                    name = "Not Authenticated";

                ErrorLogger.LogException(ex, name, "Trying to login");
                ErrorServices.AddNewError(name, "Highly Severe", "0", "Trying to login", ex.TargetSite.ToString(), ex.InnerException.Message);
                string message = "Issue with database connection settings!";
                KryptonMessageBox.Show(message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return successful;
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            var email = txtEmailAddress.Text.Trim();
            var password = txtPassword.Text.Trim();
            if (email == "") {
                KryptonMessageBox.Show("Please provide an email address!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (password == "") {
                KryptonMessageBox.Show("Please provide a password!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var successful = UserLogin(email, password);
            if (successful) {
                DialogResult = DialogResult.OK;
            } else {
                return;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e) {
            DateTime _todaysDate = DateTime.Now.Date;
            DateTime firstDayOfMonth = new DateTime(_todaysDate.Year, _todaysDate.Month, 1);
            DateTime lastDayOfMonth = new DateTime(_todaysDate.Year, _todaysDate.Month, 1).AddMonths(1).AddDays(-1);

            try {
                OverAllBalance = TransactionsHelpers.GetOverAllBalance();
                MonthlyBalance = TransactionsHelpers.GetMonthBalance(firstDayOfMonth, lastDayOfMonth);
                EmptyStockProductList = TransactionsHelpers.GetProductsWithEmptyStock();
                var t = TransactionsHelpers.GetTotalSaleForToday(_todaysDate);
                var x = TransactionsHelpers.GetTotalSalesForMonth(firstDayOfMonth, lastDayOfMonth);
                var y = TransactionsHelpers.GetTotalSalesForHalfYear(_todaysDate);
                var z = TransactionsHelpers.GetValueOfEntireStock();
            } catch (Exception ex) {
                ErrorLogger.LogException(ex, LoginCredentials.username, "Background operation to retrieve overall balance, monthly balance, products with empty stock, total sales for the day, total sales for the month, value of entire stock, and total sales for half year");
                return;
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error == null) {
                ControlHelpers.StartUpNotification("OverAll Balance", "Your overall balance is: " + OverAllBalance);

                ControlHelpers.StartUpNotification("Monthly Balance", "Your balance for this month is: " + MonthlyBalance);

                if (EmptyStockProductList.Length != 0) {
                    ControlHelpers.ErrorNotification("Products Out of Stock", "The following products are out of stock: " + EmptyStockProductList);
                }
            } else {
                ControlHelpers.ErrorNotification("Background Task Error", "Application encountered an error while loading a background task!");
            }
        }

        private void lblUserAcctConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Open a modal to set superuser account
            using (UserAccountConfig u = new UserAccountConfig()) {
                u.ShowDialog();
            }
        }
    }
}