namespace Inventory.View.Products {
    partial class SellProducts {
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
            this.panelSellProductsForm = new System.Windows.Forms.Panel();
            this.grdViewSelectedProducts = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.productID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ProductName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.SellingPrice = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Amount = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Total = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.panelAddProducts = new System.Windows.Forms.Panel();
            this.btnAddProductsToList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelBtnSubmitProducts = new System.Windows.Forms.Panel();
            this.btnSubmitProductList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ddlPaymentTypes = new System.Windows.Forms.ComboBox();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.lblProdSellingPrice = new System.Windows.Forms.Label();
            this.txtProdQuantity = new System.Windows.Forms.TextBox();
            this.txtProdSellingPrice = new System.Windows.Forms.TextBox();
            this.TablePanelComboBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.ddlCategories = new System.Windows.Forms.ComboBox();
            this.ddlProducts = new System.Windows.Forms.ComboBox();
            this.ddlSubCategories = new System.Windows.Forms.ComboBox();
            this.txtTotalSaleAmount = new System.Windows.Forms.TextBox();
            this.lblTotalSaleAmount = new System.Windows.Forms.Label();
            this.lblSelectedProducts = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panelSellProductsForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSelectedProducts)).BeginInit();
            this.panelAddProducts.SuspendLayout();
            this.panelBtnSubmitProducts.SuspendLayout();
            this.TablePanelComboBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSellProductsForm
            // 
            this.panelSellProductsForm.AutoScroll = true;
            this.panelSellProductsForm.Controls.Add(this.grdViewSelectedProducts);
            this.panelSellProductsForm.Controls.Add(this.panelAddProducts);
            this.panelSellProductsForm.Controls.Add(this.panelBtnSubmitProducts);
            this.panelSellProductsForm.Controls.Add(this.label1);
            this.panelSellProductsForm.Controls.Add(this.lblProduct);
            this.panelSellProductsForm.Controls.Add(this.lblSubCategory);
            this.panelSellProductsForm.Controls.Add(this.lblRemarks);
            this.panelSellProductsForm.Controls.Add(this.txtRemarks);
            this.panelSellProductsForm.Controls.Add(this.lblPaymentType);
            this.panelSellProductsForm.Controls.Add(this.lblCategory);
            this.panelSellProductsForm.Controls.Add(this.ddlPaymentTypes);
            this.panelSellProductsForm.Controls.Add(this.lblProdQuantity);
            this.panelSellProductsForm.Controls.Add(this.lblProdSellingPrice);
            this.panelSellProductsForm.Controls.Add(this.txtProdQuantity);
            this.panelSellProductsForm.Controls.Add(this.txtProdSellingPrice);
            this.panelSellProductsForm.Controls.Add(this.TablePanelComboBoxes);
            this.panelSellProductsForm.Controls.Add(this.txtTotalSaleAmount);
            this.panelSellProductsForm.Controls.Add(this.lblTotalSaleAmount);
            this.panelSellProductsForm.Controls.Add(this.lblSelectedProducts);
            this.panelSellProductsForm.Controls.Add(this.txtCustomerInfo);
            this.panelSellProductsForm.Controls.Add(this.txtCustomerName);
            this.panelSellProductsForm.Controls.Add(this.lblCustomerInfo);
            this.panelSellProductsForm.Controls.Add(this.lblCustomerName);
            this.panelSellProductsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSellProductsForm.Location = new System.Drawing.Point(0, 0);
            this.panelSellProductsForm.Name = "panelSellProductsForm";
            this.panelSellProductsForm.Size = new System.Drawing.Size(715, 407);
            this.panelSellProductsForm.TabIndex = 0;
            // 
            // grdViewSelectedProducts
            // 
            this.grdViewSelectedProducts.AllowUserToAddRows = false;
            this.grdViewSelectedProducts.AllowUserToResizeRows = false;
            this.grdViewSelectedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdViewSelectedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.ProductName,
            this.SellingPrice,
            this.Amount,
            this.Total});
            this.grdViewSelectedProducts.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewSelectedProducts.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewSelectedProducts.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSelectedProducts.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSelectedProducts.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSelectedProducts.Location = new System.Drawing.Point(200, 105);
            this.grdViewSelectedProducts.MultiSelect = false;
            this.grdViewSelectedProducts.Name = "grdViewSelectedProducts";
            this.grdViewSelectedProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdViewSelectedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewSelectedProducts.Size = new System.Drawing.Size(447, 103);
            this.grdViewSelectedProducts.StandardTab = true;
            this.grdViewSelectedProducts.TabIndex = 31;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "ProductID";
            this.productID.FillWeight = 49.26109F;
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 197.1008F;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 143;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.FillWeight = 77.30424F;
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            this.SellingPrice.Width = 80;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Quantity";
            this.Amount.FillWeight = 80.76266F;
            this.Amount.HeaderText = "Quantity";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 65;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Amount";
            this.Total.FillWeight = 95.57124F;
            this.Total.HeaderText = "Amount";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 78;
            // 
            // panelAddProducts
            // 
            this.panelAddProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddProducts.Controls.Add(this.btnAddProductsToList);
            this.panelAddProducts.Location = new System.Drawing.Point(485, 341);
            this.panelAddProducts.Name = "panelAddProducts";
            this.panelAddProducts.Size = new System.Drawing.Size(162, 53);
            this.panelAddProducts.TabIndex = 30;
            // 
            // btnAddProductsToList
            // 
            this.btnAddProductsToList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProductsToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.btnAddProductsToList.Location = new System.Drawing.Point(14, 18);
            this.btnAddProductsToList.Name = "btnAddProductsToList";
            this.btnAddProductsToList.Size = new System.Drawing.Size(148, 35);
            this.btnAddProductsToList.TabIndex = 27;
            this.btnAddProductsToList.Values.Text = "ADD PRODUCTS";
            this.btnAddProductsToList.Click += new System.EventHandler(this.btnAddProductsToList_Click);
            // 
            // panelBtnSubmitProducts
            // 
            this.panelBtnSubmitProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnSubmitProducts.Controls.Add(this.btnSubmitProductList);
            this.panelBtnSubmitProducts.Location = new System.Drawing.Point(200, 528);
            this.panelBtnSubmitProducts.Name = "panelBtnSubmitProducts";
            this.panelBtnSubmitProducts.Size = new System.Drawing.Size(175, 58);
            this.panelBtnSubmitProducts.TabIndex = 29;
            // 
            // btnSubmitProductList
            // 
            this.btnSubmitProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitProductList.Location = new System.Drawing.Point(3, 3);
            this.btnSubmitProductList.Name = "btnSubmitProductList";
            this.btnSubmitProductList.Size = new System.Drawing.Size(148, 35);
            this.btnSubmitProductList.TabIndex = 28;
            this.btnSubmitProductList.Values.Text = "SUBMIT";
            this.btnSubmitProductList.Click += new System.EventHandler(this.btnSubmitProductList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(491, 265);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 18);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(344, 265);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(88, 18);
            this.lblSubCategory.TabIndex = 24;
            this.lblSubCategory.Text = "SubCategory:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(100, 493);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 18);
            this.lblRemarks.TabIndex = 21;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(200, 447);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(175, 64);
            this.txtRemarks.TabIndex = 20;
            this.txtRemarks.Text = "";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(67, 414);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(96, 18);
            this.lblPaymentType.TabIndex = 19;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(197, 265);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 18);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category:";
            // 
            // ddlPaymentTypes
            // 
            this.ddlPaymentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlPaymentTypes.FormattingEnabled = true;
            this.ddlPaymentTypes.Location = new System.Drawing.Point(200, 408);
            this.ddlPaymentTypes.Name = "ddlPaymentTypes";
            this.ddlPaymentTypes.Size = new System.Drawing.Size(175, 24);
            this.ddlPaymentTypes.TabIndex = 17;
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(100, 376);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(63, 18);
            this.lblProdQuantity.TabIndex = 16;
            this.lblProdQuantity.Text = "Quantity:";
            // 
            // lblProdSellingPrice
            // 
            this.lblProdSellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdSellingPrice.AutoSize = true;
            this.lblProdSellingPrice.Location = new System.Drawing.Point(80, 341);
            this.lblProdSellingPrice.Name = "lblProdSellingPrice";
            this.lblProdSellingPrice.Size = new System.Drawing.Size(83, 18);
            this.lblProdSellingPrice.TabIndex = 15;
            this.lblProdSellingPrice.Text = "Selling Price:";
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdQuantity.Location = new System.Drawing.Point(200, 371);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(175, 24);
            this.txtProdQuantity.TabIndex = 14;
            // 
            // txtProdSellingPrice
            // 
            this.txtProdSellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdSellingPrice.Enabled = false;
            this.txtProdSellingPrice.Location = new System.Drawing.Point(200, 335);
            this.txtProdSellingPrice.Name = "txtProdSellingPrice";
            this.txtProdSellingPrice.Size = new System.Drawing.Size(175, 24);
            this.txtProdSellingPrice.TabIndex = 13;
            // 
            // TablePanelComboBoxes
            // 
            this.TablePanelComboBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelComboBoxes.AutoSize = true;
            this.TablePanelComboBoxes.ColumnCount = 3;
            this.TablePanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33556F));
            this.TablePanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.TablePanelComboBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.TablePanelComboBoxes.Controls.Add(this.ddlCategories, 0, 0);
            this.TablePanelComboBoxes.Controls.Add(this.ddlProducts, 2, 0);
            this.TablePanelComboBoxes.Controls.Add(this.ddlSubCategories, 1, 0);
            this.TablePanelComboBoxes.Location = new System.Drawing.Point(197, 286);
            this.TablePanelComboBoxes.Name = "TablePanelComboBoxes";
            this.TablePanelComboBoxes.RowCount = 1;
            this.TablePanelComboBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelComboBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TablePanelComboBoxes.Size = new System.Drawing.Size(454, 31);
            this.TablePanelComboBoxes.TabIndex = 8;
            // 
            // ddlCategories
            // 
            this.ddlCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCategories.FormattingEnabled = true;
            this.ddlCategories.Location = new System.Drawing.Point(3, 3);
            this.ddlCategories.Name = "ddlCategories";
            this.ddlCategories.Size = new System.Drawing.Size(145, 24);
            this.ddlCategories.TabIndex = 0;
            this.ddlCategories.SelectedIndexChanged += new System.EventHandler(this.ddlCategories_SelectedIndexChanged);
            // 
            // ddlProducts
            // 
            this.ddlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlProducts.FormattingEnabled = true;
            this.ddlProducts.Location = new System.Drawing.Point(305, 3);
            this.ddlProducts.Name = "ddlProducts";
            this.ddlProducts.Size = new System.Drawing.Size(146, 24);
            this.ddlProducts.TabIndex = 2;
            this.ddlProducts.SelectedIndexChanged += new System.EventHandler(this.ddlProducts_SelectedIndexChanged);
            // 
            // ddlSubCategories
            // 
            this.ddlSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSubCategories.FormattingEnabled = true;
            this.ddlSubCategories.Location = new System.Drawing.Point(154, 3);
            this.ddlSubCategories.Name = "ddlSubCategories";
            this.ddlSubCategories.Size = new System.Drawing.Size(145, 24);
            this.ddlSubCategories.TabIndex = 1;
            this.ddlSubCategories.SelectedIndexChanged += new System.EventHandler(this.ddlSubCategories_SelectedIndexChanged);
            // 
            // txtTotalSaleAmount
            // 
            this.txtTotalSaleAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSaleAmount.Enabled = false;
            this.txtTotalSaleAmount.Location = new System.Drawing.Point(536, 218);
            this.txtTotalSaleAmount.Name = "txtTotalSaleAmount";
            this.txtTotalSaleAmount.Size = new System.Drawing.Size(111, 24);
            this.txtTotalSaleAmount.TabIndex = 7;
            // 
            // lblTotalSaleAmount
            // 
            this.lblTotalSaleAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSaleAmount.AutoSize = true;
            this.lblTotalSaleAmount.Location = new System.Drawing.Point(421, 224);
            this.lblTotalSaleAmount.Name = "lblTotalSaleAmount";
            this.lblTotalSaleAmount.Size = new System.Drawing.Size(93, 18);
            this.lblTotalSaleAmount.TabIndex = 6;
            this.lblTotalSaleAmount.Text = "Total Amount:";
            // 
            // lblSelectedProducts
            // 
            this.lblSelectedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedProducts.AutoSize = true;
            this.lblSelectedProducts.Location = new System.Drawing.Point(98, 146);
            this.lblSelectedProducts.Name = "lblSelectedProducts";
            this.lblSelectedProducts.Size = new System.Drawing.Size(65, 18);
            this.lblSelectedProducts.TabIndex = 5;
            this.lblSelectedProducts.Text = "Products:";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(200, 68);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(181, 24);
            this.txtCustomerInfo.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(200, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(181, 24);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Location = new System.Drawing.Point(66, 74);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(97, 18);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Customer Info:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(55, 37);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(108, 18);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // SellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.panelSellProductsForm);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SellProducts";
            this.Size = new System.Drawing.Size(715, 407);
            this.panelSellProductsForm.ResumeLayout(false);
            this.panelSellProductsForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSelectedProducts)).EndInit();
            this.panelAddProducts.ResumeLayout(false);
            this.panelBtnSubmitProducts.ResumeLayout(false);
            this.TablePanelComboBoxes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelSellProductsForm;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Label lblSelectedProducts;
        private System.Windows.Forms.Label lblTotalSaleAmount;
        private System.Windows.Forms.TextBox txtTotalSaleAmount;
        private System.Windows.Forms.TableLayoutPanel TablePanelComboBoxes;
        private System.Windows.Forms.ComboBox ddlCategories;
        private System.Windows.Forms.ComboBox ddlProducts;
        private System.Windows.Forms.ComboBox ddlSubCategories;
        private System.Windows.Forms.TextBox txtProdSellingPrice;
        private System.Windows.Forms.Label lblProdSellingPrice;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.TextBox txtProdQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox ddlPaymentTypes;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddProductsToList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmitProductList;
        private System.Windows.Forms.Panel panelBtnSubmitProducts;
        private System.Windows.Forms.Panel panelAddProducts;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdViewSelectedProducts;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productID;
        private new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn SellingPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Amount;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Total;
    }
}
