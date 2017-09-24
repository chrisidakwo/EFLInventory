using BusinessLayer;
using EntityLayer;
using Inventory.Helpers;
using Inventory.Model;
using Inventory.Utils;
using Inventory.View.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory.View.Transactions {
    public partial class GenerateReports : UserControl, INotifyPropertyChanged {
        public BackgroundWorker worker = new BackgroundWorker();
        public List<TransactionSellingEntity> DetailedSellingEntities = new List<TransactionSellingEntity>();
        public List<TransactionPurchaseEntity> DetailedPurchaseEntities = new List<TransactionPurchaseEntity>();
        public List<SalesReportEntity> SellingEntities = new List<SalesReportEntity>();
        public List<PurchaseReportEntity> PurchaseEntities = new List<PurchaseReportEntity>();
        public bool DetailedReport = false;
        public string SelectedButton = "None";
        public string FileName = "";

        private DateTime? _DateFrom = new DateTime?();
        public DateTime DateFrom {
            get { return _DateFrom.Value; }
            set {
                _DateFrom = value;
                RaisePropertyChanged("DateFrom");
            }
        }

        private DateTime _DateTo;
        public DateTime DateTo {
            get { return _DateTo; }
            set {
                _DateTo = value;
                RaisePropertyChanged("DateTo");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void RaisePropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GenerateReports() {
            InitializeComponent();
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e) {
            if (SelectedButton == "Sales_CSV" || SelectedButton == "Sales_Excel") {
                try {
                    if (DetailedReport) {
                        DetailedSellingEntities = TransactionHistoryServices.GetAllCreditTransaction(DateFrom, DateTo);
                    } else {
                        var sales = TransactionHistoryServices.GetAllCreditTransaction(DateFrom, DateTo);
                        SellingEntities = TransactionHistoryServices.GetSalesReport(sales);
                    }
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Background Task Error", "An error occured while trying to retrieve data for the Excel document", -1);
                    ErrorLogger.LogException(ex, LoginCredentials.username, "Background task retrieving purchase and sales history for GenerateReport view");
                    return;
                }
            } else if (SelectedButton == "Purchase_CSV" || SelectedButton == "Purchase_Excel") {
                try {
                    if (DetailedReport) {
                        DetailedPurchaseEntities = TransactionHistoryServices.GetAllDebitTransaction(DateFrom, DateTo);
                    } else {
                        var purchases = TransactionHistoryServices.GetAllDebitTransaction(DateFrom, DateTo);
                        PurchaseEntities = TransactionHistoryServices.GetPurchaseReport(purchases);
                    }
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Background Task Error", "An error occured while trying to retrieve data for the CSV document", -1);
                    ErrorLogger.LogException(ex, LoginCredentials.username, "Background task retrieving purchase and sales history for GenerateReport view");
                    return;
                }
            }
        }

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            switch (SelectedButton) {
                case "Sales_CSV":
                    try {
                        if (DetailedReport) {
                            DocumentHelpers.ExportToCSV(DetailedSellingEntities, FileName);
                        } else {
                            DocumentHelpers.ExportToCSV(SellingEntities, FileName);
                        }
                        break;
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Sales_Excel":
                    try {
                        if (DetailedReport) {
                            DocumentHelpers.ExportToExcel(DetailedSellingEntities, FileName);
                        } else {
                            DocumentHelpers.ExportToExcel(SellingEntities, FileName);
                        }
                        break;
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Purchase_CSV":
                    try {
                        if (DetailedReport) {
                            DocumentHelpers.ExportToCSV(DetailedPurchaseEntities, FileName);
                        } else {
                            DocumentHelpers.ExportToCSV(PurchaseEntities, FileName);
                        }
                        break;
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Purchase_Excel":
                    try {
                        if (DetailedReport) {
                            DocumentHelpers.ExportToExcel(DetailedPurchaseEntities, FileName);
                        } else {
                            DocumentHelpers.ExportToExcel(PurchaseEntities, FileName);
                        }
                        break;
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
            }
        }

        private void btnPurchaseReportAsExcel_Click(object sender, EventArgs e) {
            FileName = txtPurchaseReportFilename.Text.Trim();
            SelectedButton = "Purchase_Excel";
            DateFrom = new DateTime(2017, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            if (chkPurchaseUseDate.Checked) {
                DateFrom = txtPurchaseDateFrom.Value.Date;
                DateTo = txtPurchaseDateTo.Value.Date;
            }

            if (chkPurchaseDetailedReport.Checked) {
                DetailedReport = true;
            }

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnPurchaseReportAsCSV_Click(object sender, EventArgs e) {
            FileName = txtPurchaseReportFilename.Text.Trim();
            SelectedButton = "Purchase_CSV";
            DateFrom = new DateTime(2017, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            if (chkPurchaseUseDate.Checked) {
                DateFrom = txtPurchaseDateFrom.Value.Date;
                DateTo = txtPurchaseDateTo.Value.Date;
            }

            if (chkPurchaseDetailedReport.Checked) {
                DetailedReport = true;
            }

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnSalesReportAsExcel_Click(object sender, EventArgs e) {
            FileName = txtSalesReportFilename.Text.Trim();
            SelectedButton = "Sales_Excel";
            DateFrom = new DateTime(2017, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            if (chkSalesUseDate.Checked) {
                DateFrom = txtPurchaseDateFrom.Value.Date;
                DateTo = txtPurchaseDateTo.Value.Date;
            }

            if (chkSalesDetailedReport.Checked) {
                DetailedReport = true;
            }

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnSalesReportAsCSV_Click(object sender, EventArgs e) {
            FileName = txtSalesReportFilename.Text.Trim();
            SelectedButton = "Sales_CSV";
            DateFrom = new DateTime(2017, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            if (chkSalesUseDate.Checked) {
                DateFrom = txtPurchaseDateFrom.Value.Date;
                DateTo = txtPurchaseDateTo.Value.Date;
            }

            if (chkSalesDetailedReport.Checked) {
                DetailedReport = true;
            }

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }
    }
}
