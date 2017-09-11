namespace Inventory.View.Products {
    partial class ProductStockEntry {
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
            this.TableLayoutPanelProductStockEntry = new System.Windows.Forms.TableLayoutPanel();
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddProductStock = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelProductStockForm = new System.Windows.Forms.Panel();
            this.txtProdDealer = new System.Windows.Forms.TextBox();
            this.txtProdAmount = new System.Windows.Forms.TextBox();
            this.txtProdSalePrice = new System.Windows.Forms.TextBox();
            this.txtProdCostPrice = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.ddlProdPaymentType = new System.Windows.Forms.ComboBox();
            this.txtProdQuantity = new System.Windows.Forms.NumericUpDown();
            this.ddlProduct = new System.Windows.Forms.ComboBox();
            this.ddlProdSubCategory = new System.Windows.Forms.ComboBox();
            this.ddlProdCategory = new System.Windows.Forms.ComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblProdPaymentType = new System.Windows.Forms.Label();
            this.lblProdAmount = new System.Windows.Forms.Label();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.lblProdSellPrice = new System.Windows.Forms.Label();
            this.lblProdCostPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblProdCategory = new System.Windows.Forms.Label();
            this.lblProdDealer = new System.Windows.Forms.Label();
            this.TableLayoutPanelProductStockEntry.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.panelProductStockForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelProductStockEntry
            // 
            this.TableLayoutPanelProductStockEntry.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TableLayoutPanelProductStockEntry.ColumnCount = 1;
            this.TableLayoutPanelProductStockEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelProductStockEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TableLayoutPanelProductStockEntry.Controls.Add(this.panelActionButtons, 0, 1);
            this.TableLayoutPanelProductStockEntry.Controls.Add(this.panelProductStockForm, 0, 0);
            this.TableLayoutPanelProductStockEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelProductStockEntry.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelProductStockEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanelProductStockEntry.Name = "TableLayoutPanelProductStockEntry";
            this.TableLayoutPanelProductStockEntry.RowCount = 2;
            this.TableLayoutPanelProductStockEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanelProductStockEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanelProductStockEntry.Size = new System.Drawing.Size(373, 512);
            this.TableLayoutPanelProductStockEntry.TabIndex = 0;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.btnCancel);
            this.panelActionButtons.Controls.Add(this.btnAddProductStock);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActionButtons.Location = new System.Drawing.Point(6, 435);
            this.panelActionButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(361, 72);
            this.panelActionButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(193, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Values.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProductStock
            // 
            this.btnAddProductStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProductStock.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.btnAddProductStock.Location = new System.Drawing.Point(23, 16);
            this.btnAddProductStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProductStock.Name = "btnAddProductStock";
            this.btnAddProductStock.Size = new System.Drawing.Size(148, 40);
            this.btnAddProductStock.TabIndex = 1;
            this.btnAddProductStock.Values.Text = "SAVE";
            this.btnAddProductStock.Click += new System.EventHandler(this.btnAddProductStock_Click);
            // 
            // panelProductStockForm
            // 
            this.panelProductStockForm.Controls.Add(this.txtProdDealer);
            this.panelProductStockForm.Controls.Add(this.txtProdAmount);
            this.panelProductStockForm.Controls.Add(this.txtProdSalePrice);
            this.panelProductStockForm.Controls.Add(this.txtProdCostPrice);
            this.panelProductStockForm.Controls.Add(this.txtRemarks);
            this.panelProductStockForm.Controls.Add(this.ddlProdPaymentType);
            this.panelProductStockForm.Controls.Add(this.txtProdQuantity);
            this.panelProductStockForm.Controls.Add(this.ddlProduct);
            this.panelProductStockForm.Controls.Add(this.ddlProdSubCategory);
            this.panelProductStockForm.Controls.Add(this.ddlProdCategory);
            this.panelProductStockForm.Controls.Add(this.lblRemarks);
            this.panelProductStockForm.Controls.Add(this.lblProdPaymentType);
            this.panelProductStockForm.Controls.Add(this.lblProdAmount);
            this.panelProductStockForm.Controls.Add(this.lblProdQuantity);
            this.panelProductStockForm.Controls.Add(this.lblProdSellPrice);
            this.panelProductStockForm.Controls.Add(this.lblProdCostPrice);
            this.panelProductStockForm.Controls.Add(this.lblProduct);
            this.panelProductStockForm.Controls.Add(this.lblSubCategory);
            this.panelProductStockForm.Controls.Add(this.lblProdCategory);
            this.panelProductStockForm.Controls.Add(this.lblProdDealer);
            this.panelProductStockForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductStockForm.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.panelProductStockForm.Location = new System.Drawing.Point(6, 5);
            this.panelProductStockForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProductStockForm.Name = "panelProductStockForm";
            this.panelProductStockForm.Size = new System.Drawing.Size(361, 423);
            this.panelProductStockForm.TabIndex = 1;
            // 
            // txtProdDealer
            // 
            this.txtProdDealer.Enabled = false;
            this.txtProdDealer.Location = new System.Drawing.Point(154, 21);
            this.txtProdDealer.Name = "txtProdDealer";
            this.txtProdDealer.Size = new System.Drawing.Size(188, 24);
            this.txtProdDealer.TabIndex = 23;
            // 
            // txtProdAmount
            // 
            this.txtProdAmount.Enabled = false;
            this.txtProdAmount.Location = new System.Drawing.Point(154, 278);
            this.txtProdAmount.Name = "txtProdAmount";
            this.txtProdAmount.Size = new System.Drawing.Size(188, 24);
            this.txtProdAmount.TabIndex = 22;
            // 
            // txtProdSalePrice
            // 
            this.txtProdSalePrice.Enabled = false;
            this.txtProdSalePrice.Location = new System.Drawing.Point(154, 204);
            this.txtProdSalePrice.Name = "txtProdSalePrice";
            this.txtProdSalePrice.Size = new System.Drawing.Size(188, 24);
            this.txtProdSalePrice.TabIndex = 21;
            // 
            // txtProdCostPrice
            // 
            this.txtProdCostPrice.Enabled = false;
            this.txtProdCostPrice.Location = new System.Drawing.Point(154, 167);
            this.txtProdCostPrice.Name = "txtProdCostPrice";
            this.txtProdCostPrice.Size = new System.Drawing.Size(188, 24);
            this.txtProdCostPrice.TabIndex = 20;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(154, 351);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(188, 44);
            this.txtRemarks.TabIndex = 19;
            this.txtRemarks.Text = "";
            // 
            // ddlProdPaymentType
            // 
            this.ddlProdPaymentType.FormattingEnabled = true;
            this.ddlProdPaymentType.Location = new System.Drawing.Point(154, 315);
            this.ddlProdPaymentType.Name = "ddlProdPaymentType";
            this.ddlProdPaymentType.Size = new System.Drawing.Size(188, 24);
            this.ddlProdPaymentType.TabIndex = 18;
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.Location = new System.Drawing.Point(154, 241);
            this.txtProdQuantity.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(188, 24);
            this.txtProdQuantity.TabIndex = 16;
            this.txtProdQuantity.ThousandsSeparator = true;
            this.txtProdQuantity.ValueChanged += new System.EventHandler(this.txtProdQuantity_ValueChanged);
            // 
            // ddlProduct
            // 
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Location = new System.Drawing.Point(154, 130);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(188, 24);
            this.ddlProduct.TabIndex = 13;
            this.ddlProduct.SelectedIndexChanged += new System.EventHandler(this.ddlProduct_SelectedIndexChanged);
            // 
            // ddlProdSubCategory
            // 
            this.ddlProdSubCategory.FormattingEnabled = true;
            this.ddlProdSubCategory.Location = new System.Drawing.Point(154, 93);
            this.ddlProdSubCategory.Name = "ddlProdSubCategory";
            this.ddlProdSubCategory.Size = new System.Drawing.Size(188, 24);
            this.ddlProdSubCategory.TabIndex = 12;
            this.ddlProdSubCategory.SelectedIndexChanged += new System.EventHandler(this.ddlProdSubCategory_SelectedIndexChanged);
            // 
            // ddlProdCategory
            // 
            this.ddlProdCategory.FormattingEnabled = true;
            this.ddlProdCategory.Location = new System.Drawing.Point(154, 56);
            this.ddlProdCategory.Name = "ddlProdCategory";
            this.ddlProdCategory.Size = new System.Drawing.Size(188, 24);
            this.ddlProdCategory.TabIndex = 11;
            this.ddlProdCategory.SelectedIndexChanged += new System.EventHandler(this.ddlProdCategory_SelectedIndexChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(77, 377);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 18);
            this.lblRemarks.TabIndex = 9;
            this.lblRemarks.Text = "Remarks:";
            // 
            // lblProdPaymentType
            // 
            this.lblProdPaymentType.AutoSize = true;
            this.lblProdPaymentType.Location = new System.Drawing.Point(44, 321);
            this.lblProdPaymentType.Name = "lblProdPaymentType";
            this.lblProdPaymentType.Size = new System.Drawing.Size(96, 18);
            this.lblProdPaymentType.TabIndex = 8;
            this.lblProdPaymentType.Text = "Payment Type:";
            // 
            // lblProdAmount
            // 
            this.lblProdAmount.AutoSize = true;
            this.lblProdAmount.Location = new System.Drawing.Point(80, 284);
            this.lblProdAmount.Name = "lblProdAmount";
            this.lblProdAmount.Size = new System.Drawing.Size(60, 18);
            this.lblProdAmount.TabIndex = 7;
            this.lblProdAmount.Text = "Amount:";
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(77, 247);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(63, 18);
            this.lblProdQuantity.TabIndex = 6;
            this.lblProdQuantity.Text = "Quantity:";
            // 
            // lblProdSellPrice
            // 
            this.lblProdSellPrice.AutoSize = true;
            this.lblProdSellPrice.Location = new System.Drawing.Point(57, 210);
            this.lblProdSellPrice.Name = "lblProdSellPrice";
            this.lblProdSellPrice.Size = new System.Drawing.Size(83, 18);
            this.lblProdSellPrice.TabIndex = 5;
            this.lblProdSellPrice.Text = "Selling Price:";
            // 
            // lblProdCostPrice
            // 
            this.lblProdCostPrice.AutoSize = true;
            this.lblProdCostPrice.Location = new System.Drawing.Point(70, 173);
            this.lblProdCostPrice.Name = "lblProdCostPrice";
            this.lblProdCostPrice.Size = new System.Drawing.Size(70, 18);
            this.lblProdCostPrice.TabIndex = 4;
            this.lblProdCostPrice.Text = "Cost Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(81, 136);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 18);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(52, 99);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(88, 18);
            this.lblSubCategory.TabIndex = 2;
            this.lblSubCategory.Text = "SubCategory:";
            // 
            // lblProdCategory
            // 
            this.lblProdCategory.AutoSize = true;
            this.lblProdCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdCategory.Location = new System.Drawing.Point(75, 62);
            this.lblProdCategory.Name = "lblProdCategory";
            this.lblProdCategory.Size = new System.Drawing.Size(65, 18);
            this.lblProdCategory.TabIndex = 1;
            this.lblProdCategory.Text = "Category:";
            // 
            // lblProdDealer
            // 
            this.lblProdDealer.AutoSize = true;
            this.lblProdDealer.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdDealer.Location = new System.Drawing.Point(90, 27);
            this.lblProdDealer.Name = "lblProdDealer";
            this.lblProdDealer.Size = new System.Drawing.Size(50, 18);
            this.lblProdDealer.TabIndex = 0;
            this.lblProdDealer.Text = "Dealer:";
            // 
            // ProductStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(373, 512);
            this.Controls.Add(this.TableLayoutPanelProductStockEntry);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductStockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Stock Entry";
            this.TableLayoutPanelProductStockEntry.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            this.panelProductStockForm.ResumeLayout(false);
            this.panelProductStockForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanelProductStockEntry;
        internal System.Windows.Forms.Panel panelActionButtons;
        internal System.Windows.Forms.Panel panelProductStockForm;
        internal System.Windows.Forms.Label lblProdDealer;
        internal System.Windows.Forms.Label lblProdCategory;
        internal System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblProduct;
        internal System.Windows.Forms.Label lblProdSellPrice;
        internal System.Windows.Forms.Label lblProdCostPrice;
        internal System.Windows.Forms.Label lblProdAmount;
        internal System.Windows.Forms.Label lblProdQuantity;
        internal System.Windows.Forms.Label lblProdPaymentType;
        internal System.Windows.Forms.Label lblRemarks;
        internal System.Windows.Forms.ComboBox ddlProdCategory;
        internal System.Windows.Forms.ComboBox ddlProdSubCategory;
        internal System.Windows.Forms.ComboBox ddlProduct;
        internal System.Windows.Forms.NumericUpDown txtProdQuantity;
        internal System.Windows.Forms.ComboBox ddlProdPaymentType;
        internal System.Windows.Forms.RichTextBox txtRemarks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddProductStock;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        internal System.Windows.Forms.TextBox txtProdSalePrice;
        internal System.Windows.Forms.TextBox txtProdCostPrice;
        internal System.Windows.Forms.TextBox txtProdAmount;
        internal System.Windows.Forms.TextBox txtProdDealer;
    }
}