namespace Inventory.View.Transactions {
    partial class UpdateTransactionDetails {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransactionDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.chkIsWholeSale = new System.Windows.Forms.CheckBox();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateTransactionHistory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblProdChange = new System.Windows.Forms.Label();
            this.txtProdChange = new System.Windows.Forms.NumericUpDown();
            this.txtProdBalanceDue = new System.Windows.Forms.NumericUpDown();
            this.txtProdQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProdBalanceDue = new System.Windows.Forms.Label();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdBalanceDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.lblRemarks);
            this.panel1.Controls.Add(this.chkIsWholeSale);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUpdateTransactionHistory);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.lblProdChange);
            this.panel1.Controls.Add(this.txtProdChange);
            this.panel1.Controls.Add(this.txtProdBalanceDue);
            this.panel1.Controls.Add(this.txtProdQuantity);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblProdBalanceDue);
            this.panel1.Controls.Add(this.lblProdQuantity);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.txtTransactionID);
            this.panel1.Controls.Add(this.lblTransactionID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 367);
            this.panel1.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(139, 229);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(162, 69);
            this.txtRemarks.TabIndex = 16;
            this.txtRemarks.Text = "";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(49, 229);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 18);
            this.lblRemarks.TabIndex = 15;
            this.lblRemarks.Text = "Remarks:";
            // 
            // chkIsWholeSale
            // 
            this.chkIsWholeSale.AutoSize = true;
            this.chkIsWholeSale.Location = new System.Drawing.Point(139, 201);
            this.chkIsWholeSale.Name = "chkIsWholeSale";
            this.chkIsWholeSale.Size = new System.Drawing.Size(108, 22);
            this.chkIsWholeSale.TabIndex = 14;
            this.chkIsWholeSale.Text = "Is Wholesale?";
            this.chkIsWholeSale.UseVisualStyleBackColor = true;
            this.chkIsWholeSale.CheckedChanged += new System.EventHandler(this.chkIsWholeSale_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Values.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateTransactionHistory
            // 
            this.btnUpdateTransactionHistory.Location = new System.Drawing.Point(42, 320);
            this.btnUpdateTransactionHistory.MinimumSize = new System.Drawing.Size(0, 5);
            this.btnUpdateTransactionHistory.Name = "btnUpdateTransactionHistory";
            this.btnUpdateTransactionHistory.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateTransactionHistory.TabIndex = 12;
            this.btnUpdateTransactionHistory.Values.Text = "UPDATE";
            this.btnUpdateTransactionHistory.Click += new System.EventHandler(this.btnUpdateTransactionHistory_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(19, 175);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(93, 18);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(139, 169);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(162, 24);
            this.txtTotalAmount.TabIndex = 10;
            // 
            // lblProdChange
            // 
            this.lblProdChange.AutoSize = true;
            this.lblProdChange.Location = new System.Drawing.Point(56, 144);
            this.lblProdChange.Name = "lblProdChange";
            this.lblProdChange.Size = new System.Drawing.Size(56, 18);
            this.lblProdChange.TabIndex = 9;
            this.lblProdChange.Text = "Change:";
            // 
            // txtProdChange
            // 
            this.txtProdChange.Location = new System.Drawing.Point(139, 138);
            this.txtProdChange.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdChange.Name = "txtProdChange";
            this.txtProdChange.Size = new System.Drawing.Size(162, 24);
            this.txtProdChange.TabIndex = 8;
            // 
            // txtProdBalanceDue
            // 
            this.txtProdBalanceDue.Location = new System.Drawing.Point(139, 107);
            this.txtProdBalanceDue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdBalanceDue.Name = "txtProdBalanceDue";
            this.txtProdBalanceDue.Size = new System.Drawing.Size(162, 24);
            this.txtProdBalanceDue.TabIndex = 7;
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.Location = new System.Drawing.Point(139, 76);
            this.txtProdQuantity.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(162, 24);
            this.txtProdQuantity.TabIndex = 6;
            this.txtProdQuantity.ValueChanged += new System.EventHandler(this.txtProdQuantity_ValueChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(139, 46);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(162, 24);
            this.txtProductName.TabIndex = 5;
            // 
            // lblProdBalanceDue
            // 
            this.lblProdBalanceDue.AutoSize = true;
            this.lblProdBalanceDue.Location = new System.Drawing.Point(27, 113);
            this.lblProdBalanceDue.Name = "lblProdBalanceDue";
            this.lblProdBalanceDue.Size = new System.Drawing.Size(85, 18);
            this.lblProdBalanceDue.TabIndex = 4;
            this.lblProdBalanceDue.Text = "Balance Due:";
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(49, 82);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(63, 18);
            this.lblProdQuantity.TabIndex = 3;
            this.lblProdQuantity.Text = "Quantity:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 52);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(97, 18);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Enabled = false;
            this.txtTransactionID.Location = new System.Drawing.Point(139, 15);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(162, 24);
            this.txtTransactionID.TabIndex = 1;
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(16, 21);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(96, 18);
            this.lblTransactionID.TabIndex = 0;
            this.lblTransactionID.Text = "Transaction ID:";
            // 
            // UpdateTransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(334, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateTransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Transaction Details";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdBalanceDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProdBalanceDue;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.NumericUpDown txtProdQuantity;
        private System.Windows.Forms.NumericUpDown txtProdBalanceDue;
        private System.Windows.Forms.Label lblProdChange;
        private System.Windows.Forms.NumericUpDown txtProdChange;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateTransactionHistory;
        private System.Windows.Forms.CheckBox chkIsWholeSale;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
    }
}