using ComponentFactory.Krypton.Toolkit;

namespace Inventory.View.Transactions {
    partial class ViewTransactions {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupSelectDateRange = new System.Windows.Forms.GroupBox();
            this.btnSearchDate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblBalanceHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdViewPurchaseTransactions = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.purchaseDealerName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchaseProductName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchaseProductQty = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchaseProductCredit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchaseProductDebit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchasePaymentType = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchaseRemarks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.purchasePaymentDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdViewSellingHistory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.productName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productQty = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.creditTransaction = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.debitTransaction = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.paymentType = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.transactionRemarks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.customerName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.customerInfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.paymentDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupSelectDateRange.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPurchaseTransactions)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSellingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.02568F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.97432F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupSelectDateRange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 65);
            this.panel1.TabIndex = 0;
            // 
            // groupSelectDateRange
            // 
            this.groupSelectDateRange.Controls.Add(this.btnSearchDate);
            this.groupSelectDateRange.Controls.Add(this.txtDateTo);
            this.groupSelectDateRange.Controls.Add(this.lblDateTo);
            this.groupSelectDateRange.Controls.Add(this.txtDateFrom);
            this.groupSelectDateRange.Controls.Add(this.lblDateFrom);
            this.groupSelectDateRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSelectDateRange.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupSelectDateRange.ForeColor = System.Drawing.Color.White;
            this.groupSelectDateRange.Location = new System.Drawing.Point(0, 0);
            this.groupSelectDateRange.Name = "groupSelectDateRange";
            this.groupSelectDateRange.Size = new System.Drawing.Size(568, 65);
            this.groupSelectDateRange.TabIndex = 0;
            this.groupSelectDateRange.TabStop = false;
            this.groupSelectDateRange.Text = "Select date range";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDate.Location = new System.Drawing.Point(454, 22);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(103, 28);
            this.btnSearchDate.TabIndex = 4;
            this.btnSearchDate.Values.Text = "SEARCH";
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.Location = new System.Drawing.Point(302, 25);
            this.txtDateTo.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.txtDateTo.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(143, 24);
            this.txtDateTo.TabIndex = 3;
            this.txtDateTo.Value = new System.DateTime(2017, 9, 9, 13, 2, 42, 0);
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(243, 28);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(53, 18);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "DateTo:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.Location = new System.Drawing.Point(86, 25);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(143, 24);
            this.txtDateFrom.TabIndex = 1;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(6, 28);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(74, 18);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBalanceAmount);
            this.panel2.Controls.Add(this.lblBalanceHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.panel2.Location = new System.Drawing.Point(579, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 65);
            this.panel2.TabIndex = 1;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Location = new System.Drawing.Point(5, 33);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(112, 35);
            this.lblBalanceAmount.TabIndex = 1;
            this.lblBalanceAmount.Text = "N35,000,000.00";
            // 
            // lblBalanceHeader
            // 
            this.lblBalanceHeader.AutoSize = true;
            this.lblBalanceHeader.Font = new System.Drawing.Font("Source Sans Pro Semibold", 12F);
            this.lblBalanceHeader.Location = new System.Drawing.Point(4, 11);
            this.lblBalanceHeader.Name = "lblBalanceHeader";
            this.lblBalanceHeader.Size = new System.Drawing.Size(77, 20);
            this.lblBalanceHeader.TabIndex = 0;
            this.lblBalanceHeader.Text = "BALANCE:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 88);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 313);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdViewPurchaseTransactions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 149);
            this.panel3.TabIndex = 0;
            // 
            // grdViewPurchaseTransactions
            // 
            this.grdViewPurchaseTransactions.AllowUserToAddRows = false;
            this.grdViewPurchaseTransactions.AllowUserToDeleteRows = false;
            this.grdViewPurchaseTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseDealerName,
            this.purchaseProductName,
            this.purchaseProductQty,
            this.purchaseProductCredit,
            this.purchaseProductDebit,
            this.purchasePaymentType,
            this.purchaseRemarks,
            this.purchasePaymentDate});
            this.grdViewPurchaseTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewPurchaseTransactions.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewPurchaseTransactions.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewPurchaseTransactions.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewPurchaseTransactions.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewPurchaseTransactions.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewPurchaseTransactions.Location = new System.Drawing.Point(0, 0);
            this.grdViewPurchaseTransactions.MultiSelect = false;
            this.grdViewPurchaseTransactions.Name = "grdViewPurchaseTransactions";
            this.grdViewPurchaseTransactions.ReadOnly = true;
            this.grdViewPurchaseTransactions.Size = new System.Drawing.Size(695, 149);
            this.grdViewPurchaseTransactions.TabIndex = 0;
            // 
            // purchaseDealerName
            // 
            this.purchaseDealerName.DataPropertyName = "DealerName";
            this.purchaseDealerName.HeaderText = "Dealer Name";
            this.purchaseDealerName.Name = "purchaseDealerName";
            this.purchaseDealerName.ReadOnly = true;
            this.purchaseDealerName.Width = 100;
            // 
            // purchaseProductName
            // 
            this.purchaseProductName.DataPropertyName = "ProductName";
            this.purchaseProductName.HeaderText = "Product Name";
            this.purchaseProductName.Name = "purchaseProductName";
            this.purchaseProductName.ReadOnly = true;
            this.purchaseProductName.Width = 100;
            // 
            // purchaseProductQty
            // 
            this.purchaseProductQty.DataPropertyName = "Quantity";
            this.purchaseProductQty.HeaderText = "Quantity";
            this.purchaseProductQty.Name = "purchaseProductQty";
            this.purchaseProductQty.ReadOnly = true;
            this.purchaseProductQty.Width = 100;
            // 
            // purchaseProductCredit
            // 
            this.purchaseProductCredit.DataPropertyName = "Credit";
            this.purchaseProductCredit.HeaderText = "Credit";
            this.purchaseProductCredit.Name = "purchaseProductCredit";
            this.purchaseProductCredit.ReadOnly = true;
            this.purchaseProductCredit.Width = 100;
            // 
            // purchaseProductDebit
            // 
            this.purchaseProductDebit.DataPropertyName = "Debit";
            this.purchaseProductDebit.HeaderText = "Debit";
            this.purchaseProductDebit.Name = "purchaseProductDebit";
            this.purchaseProductDebit.ReadOnly = true;
            this.purchaseProductDebit.Width = 100;
            // 
            // purchasePaymentType
            // 
            this.purchasePaymentType.DataPropertyName = "PaymentType";
            this.purchasePaymentType.HeaderText = "Payment Type";
            this.purchasePaymentType.Name = "purchasePaymentType";
            this.purchasePaymentType.ReadOnly = true;
            this.purchasePaymentType.Width = 100;
            // 
            // purchaseRemarks
            // 
            this.purchaseRemarks.DataPropertyName = "Remarks";
            this.purchaseRemarks.HeaderText = "Remarks";
            this.purchaseRemarks.Name = "purchaseRemarks";
            this.purchaseRemarks.ReadOnly = true;
            this.purchaseRemarks.Width = 100;
            // 
            // purchasePaymentDate
            // 
            this.purchasePaymentDate.DataPropertyName = "PaymentDate";
            this.purchasePaymentDate.HeaderText = "Payment Date";
            this.purchasePaymentDate.Name = "purchasePaymentDate";
            this.purchasePaymentDate.ReadOnly = true;
            this.purchasePaymentDate.Width = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdViewSellingHistory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 149);
            this.panel4.TabIndex = 1;
            // 
            // grdViewSellingHistory
            // 
            this.grdViewSellingHistory.AllowUserToAddRows = false;
            this.grdViewSellingHistory.AllowUserToDeleteRows = false;
            this.grdViewSellingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productQty,
            this.creditTransaction,
            this.debitTransaction,
            this.paymentType,
            this.transactionRemarks,
            this.customerName,
            this.customerInfo,
            this.paymentDate});
            this.grdViewSellingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewSellingHistory.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewSellingHistory.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewSellingHistory.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSellingHistory.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSellingHistory.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSellingHistory.Location = new System.Drawing.Point(0, 0);
            this.grdViewSellingHistory.MultiSelect = false;
            this.grdViewSellingHistory.Name = "grdViewSellingHistory";
            this.grdViewSellingHistory.ReadOnly = true;
            this.grdViewSellingHistory.Size = new System.Drawing.Size(695, 149);
            this.grdViewSellingHistory.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "ProductName";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 100;
            // 
            // productQty
            // 
            this.productQty.DataPropertyName = "Quantity";
            this.productQty.HeaderText = "Quantity";
            this.productQty.Name = "productQty";
            this.productQty.ReadOnly = true;
            this.productQty.Width = 100;
            // 
            // creditTransaction
            // 
            this.creditTransaction.DataPropertyName = "Credit";
            this.creditTransaction.HeaderText = "Credit";
            this.creditTransaction.Name = "creditTransaction";
            this.creditTransaction.ReadOnly = true;
            this.creditTransaction.Width = 100;
            // 
            // debitTransaction
            // 
            this.debitTransaction.DataPropertyName = "Debit";
            this.debitTransaction.HeaderText = "Debit";
            this.debitTransaction.Name = "debitTransaction";
            this.debitTransaction.ReadOnly = true;
            this.debitTransaction.Width = 100;
            // 
            // paymentType
            // 
            this.paymentType.DataPropertyName = "PaymentType";
            this.paymentType.HeaderText = "Payment Type";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            this.paymentType.Width = 100;
            // 
            // transactionRemarks
            // 
            this.transactionRemarks.DataPropertyName = "Remarks";
            this.transactionRemarks.HeaderText = "Remarks";
            this.transactionRemarks.Name = "transactionRemarks";
            this.transactionRemarks.ReadOnly = true;
            this.transactionRemarks.Width = 100;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "CustomerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 100;
            // 
            // customerInfo
            // 
            this.customerInfo.DataPropertyName = "CustomerInfo";
            this.customerInfo.HeaderText = "Customer Info";
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.ReadOnly = true;
            this.customerInfo.Width = 100;
            // 
            // paymentDate
            // 
            this.paymentDate.DataPropertyName = "PaymentDate";
            this.paymentDate.HeaderText = "Payment Date";
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.ReadOnly = true;
            this.paymentDate.Width = 100;
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTransactions";
            this.Size = new System.Drawing.Size(715, 407);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupSelectDateRange.ResumeLayout(false);
            this.groupSelectDateRange.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPurchaseTransactions)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSellingHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupSelectDateRange;
        private System.Windows.Forms.DateTimePicker txtDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker txtDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private KryptonButton btnSearchDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBalanceHeader;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private KryptonDataGridView grdViewPurchaseTransactions;
        private System.Windows.Forms.Panel panel4;
        private KryptonDataGridView grdViewSellingHistory;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productQty;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn creditTransaction;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn debitTransaction;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn paymentType;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn transactionRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn customerName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn customerInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn paymentDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseDealerName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseProductQty;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseProductCredit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseProductDebit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchasePaymentType;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchaseRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn purchasePaymentDate;
    }
}
