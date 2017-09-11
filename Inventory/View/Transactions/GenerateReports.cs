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
        public List<TransactionSellingEntity> SellingEntities = new List<TransactionSellingEntity>();
        public List<TransactionPurchaseEntity> PurchaseEntities = new List<TransactionPurchaseEntity>();
        public string SelectedButton = "None";

        private DateTime _DateFrom;
        public DateTime DateFrom {
            get { return _DateFrom; }
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
            if (SelectedButton == "Selling_CSV" || SelectedButton == "Selling_Excel") {
                try {
                    SellingEntities = SellingHistoryServices.GetAllCreditTransaction(DateFrom, DateTo);
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Background Task Error", "An error occured while trying to retrieve data for the Excel document", -1);
                    ErrorLogger.LogException(ex, LoginCredentials.username, "Background task retrieving purchase and sales history for GenerateReport view");
                }
            } else if (SelectedButton == "Purchase_CSV" || SelectedButton == "Purchase_Excel") {
                try {
                    PurchaseEntities = SellingHistoryServices.GetAllDebitTransaction(DateFrom, DateTo);
                } catch (Exception ex) {
                    ControlHelpers.ErrorNotification("Background Task Error", "An error occured while trying to retrieve data for the Excel document", -1);
                    ErrorLogger.LogException(ex, LoginCredentials.username, "Background task retrieving purchase and sales history for GenerateReport view");
                }
            }
        }

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            switch (SelectedButton) {
                case "Selling_CSV":
                    try {
                        DocumentHelpers.ExportToCsv(SellingEntities);
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Selling_Excel":
                    try {
                        DocumentHelpers.ExportToCsv(SellingEntities);
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Purchase_CSV":
                    try {
                        DocumentHelpers.ExportToCsv(PurchaseEntities);
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
                case "Purchase_Excel":
                    try {
                        DocumentHelpers.ExportToCsv(PurchaseEntities);
                    } catch (Exception ex) {
                        ErrorLogger.LogException(ex, LoginCredentials.username, "");
                    }
                    break;
            }
        }

        private void btnGenerateGeneralReportAsExcel_Click(object sender, EventArgs e) {
            SelectedButton = "Purchase_Excel";
            DateFrom = new DateTime(1193, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnGenerateGeneralReportAsCSV_Click(object sender, EventArgs e) {
            SelectedButton = "Purchase_CSV";
            DateFrom = new DateTime(1193, 1, 1).Date;
            DateTo = new DateTime(2090, 1, 1).Date;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnGenerateSpecifReportExcel_Click(object sender, EventArgs e) {
            SelectedButton = "Purchase_Excel";
            DateFrom = txtDateFrom.Value.Date;
            DateTo = txtDateTo.Value.Date;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btnGenerateSpecifReportCSV_Click(object sender, EventArgs e) {
            SelectedButton = "Purchase_CSV";
            DateFrom = txtDateFrom.Value.Date;
            DateTo = txtDateTo.Value.Date;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }
    }
}