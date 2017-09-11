using BusinessLayer;
using EntityLayer;
using Inventory.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory.View.Transactions {
    public partial class ViewTransactions : UserControl, INotifyPropertyChanged {
        private List<TransactionSellingEntity> _SellingHistories;
        public List<TransactionSellingEntity> SellingHistories {
            get { return _SellingHistories; }
            set {
                _SellingHistories = value;
                RaisedPropertyChanged("SellingHistories");
            }
        }

        private List<TransactionPurchaseEntity> _PurchaseHistories;
        public List<TransactionPurchaseEntity> PurchaseHistories {
            get { return _PurchaseHistories; }
            set {
                _PurchaseHistories = value;
                RaisedPropertyChanged("PurchaseHistories");
            }
        }

        private string _OverAllBalance;
        public string OverAllBalance {
            get { return _OverAllBalance; }
            set {
                _OverAllBalance = value;
                RaisedPropertyChanged("OverAllBalance");
            }
        }

        private DateTime? _FromDate;
        public DateTime? FromDate {
            get { return _FromDate; }
            set {
                _FromDate = value;
                RaisedPropertyChanged("FromDate");
            }
        }

        private DateTime? _ToDate;
        public DateTime? ToDate {
            get { return _ToDate; }
            set {
                _ToDate = value;
                RaisedPropertyChanged("FromDate");
            }
        }

        public BackgroundWorker worker = new BackgroundWorker();

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedPropertyChanged(string PropertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public ViewTransactions() {
            InitializeComponent();
            lblBalanceAmount.DataBindings.Add(new Binding("Text", this, "OverAllBalance"));

            // Run background worker
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        public void worker_DoWork(object sender, DoWorkEventArgs e) {
            SellingHistories = SellingHistoryServices.GetAllCreditTransaction(FromDate, ToDate);
            PurchaseHistories = SellingHistoryServices.GetAllDebitTransaction(FromDate, ToDate);
            OverAllBalance = TransactionsHelpers.OverAllBalance;
        }

        public void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            DataHelpers.LoadGridViewData(grdViewSellingHistory, SellingHistories);
            DataHelpers.LoadGridViewData(grdViewPurchaseTransactions, PurchaseHistories);
        }

        public void btnSearchDate_Click(object sender, EventArgs e) {
            FromDate = txtDateFrom.Value.Date;
            ToDate = txtDateTo.Value.Date;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }
    }
}