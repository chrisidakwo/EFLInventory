using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using EntityLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.View;
using Inventory.View.About;
using Inventory.View.Categories;
using Inventory.View.Charts;
using Inventory.View.Dealers;
using Inventory.View.Helpers;
using Inventory.View.Products;
using Inventory.View.SubCategories;
using Inventory.View.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory {
    public partial class Main : KryptonForm, INotifyPropertyChanged {
        public BackgroundWorker worker = new BackgroundWorker();

        public event PropertyChangedEventHandler PropertyChanged;

        private string _TodaySales;
        public string TodaySales {
            get { return _TodaySales; }
            set {
                _TodaySales = value;
                OnPropertyChanged("TodaySales");
            }
        }

        private string _MonthSales;
        public string MonthSales {
            get { return _MonthSales; }
            set {
                _MonthSales = value;
                OnPropertyChanged("MonthSales");
            }
        }

        private string _HalfYrSales;
        public string HalfYrSales {
            get { return _HalfYrSales; }
            set {
                _HalfYrSales = value;
                OnPropertyChanged("HalfYrSales");
            }
        }

        private string _StocksValue;
        public string StocksValue {
            get { return _StocksValue; }
            set {
                _StocksValue = value;
                OnPropertyChanged("StocksValue");
            }
        }

        public List<InventorySummaryEntity> Summaries = new List<InventorySummaryEntity>();

        public virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Main() {
            InitializeComponent();
            lblSalesTodayAmt.DataBindings.Add(new Binding("Text", this, "TodaySales"));
            lblSalesMonthAmt.DataBindings.Add(new Binding("Text", this, "MonthSales"));
            lblSalesHalfYearAmt.DataBindings.Add(new Binding("Text", this, "HalfYrSales"));
            lblEntireStockValueAmt.DataBindings.Add(new Binding("Text", this, "StocksValue"));

            PopulateGridView();

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void PopulateGridView() {
            Summaries = InventoryServices.GetInventorySummary();
            DataHelpers.LoadGridViewData(grdViewInventorySummary, Summaries);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            lblAuthText.Text = "Logged in as: " + LoginCredentials.username;
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e) {
            DateTime today = DateTime.Now.Date;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);
            TodaySales = TransactionsHelpers.GetTotalSaleForToday(today);
            MonthSales = TransactionsHelpers.GetTotalSalesForMonth(firstDayOfMonth, lastDayOfMonth);
            HalfYrSales = TransactionsHelpers.GetTotalSalesForHalfYear(today);
            StocksValue = TransactionsHelpers.GetValueOfEntireStock();
        }

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            lblSalesTodayAmt.Text = TodaySales;
            lblSalesMonthAmt.Text = MonthSales;
            lblSalesHalfYearAmt.Text = HalfYrSales;
            lblEntireStockValueAmt.Text = StocksValue;
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            Application.ExitThread();
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Application.ExitThread();
            Application.Exit();
        }

        private void inventorySummaryToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
            AddUpdateCategory cat = new AddUpdateCategory();
            cat.ShowDialog();
        }

        private void viewCategoriesToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewCategories().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void addSubCategoriesToolStripMenuItem_Click(object sender, EventArgs e) {
            AddUpdateSubCategory subcat = new AddUpdateSubCategory();
            subcat.ShowDialog();
        }

        private void viewSubCategoriesToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewSubCategories().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e) {
            AddUpdateProduct productView = new AddUpdateProduct();
            productView.ShowDialog();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewProducts().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void productStockEntryToolStripMenuItem_Click(object sender, EventArgs e) {
            ProductStockEntry stockEntry = new ProductStockEntry();
            stockEntry.ShowDialog();
        }

        private void sellProductToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new SellProducts().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void addDealerToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewCategories().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewSubCategories().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void viewDealersToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewDealers().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutEFL about = new AboutEFL();
            about.ShowDialog();
        }

        private void testChartToolStripMenuItem_Click(object sender, EventArgs e) {
            var tc = new TestChart().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, tc);
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new ViewTransactions().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void generateReportMSExcelToolStripMenuItem_Click(object sender, EventArgs e) {
            var gridView = grdViewInventorySummary;
            DocumentHelpers.ExportToExcelInterop(gridView);
        }

        private void generateReportCSVToolStripMenuItem_Click(object sender, EventArgs e) {
            var gridview = grdViewInventorySummary;
            DocumentHelpers.ExportToCsv<InventorySummaryEntity>(gridview);
        }

        private void downloadTransactionsReportToolStripMenuItem_Click(object sender, EventArgs e) {
            var controls = new GenerateReports().Controls;
            ControlHelpers.DisplayUserControl(mainView_splitContainer, controls);
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            UserAccountConfig account = new UserAccountConfig();
            account.ShowDialog();
        }
    }
}