namespace Inventory.View.Products {
    partial class AddUpdateProduct {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateProduct));
            this.TableLayoutPanelAddUpdateProduct = new System.Windows.Forms.TableLayoutPanel();
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddUpdateProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelAddUpdateProductForm = new System.Windows.Forms.Panel();
            this.lblProdSuppliedQty = new System.Windows.Forms.Label();
            this.lblProdSalePrice = new System.Windows.Forms.Label();
            this.lblProdCostPrice = new System.Windows.Forms.Label();
            this.lblProdWeight = new System.Windows.Forms.Label();
            this.lblProdSubCategory = new System.Windows.Forms.Label();
            this.lblProdCategory = new System.Windows.Forms.Label();
            this.txtProdSuppliedQty = new System.Windows.Forms.NumericUpDown();
            this.txtProductSalePrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductCostPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductWeight = new System.Windows.Forms.NumericUpDown();
            this.ddlProdSubCategory = new System.Windows.Forms.ComboBox();
            this.ddlProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProdDealer = new System.Windows.Forms.Label();
            this.lblProdBrand = new System.Windows.Forms.Label();
            this.ddlProductDealer = new System.Windows.Forms.ComboBox();
            this.txtProductBrand = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.TableLayoutPanelAddUpdateProduct.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.panelAddUpdateProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdSuppliedQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelAddUpdateProduct
            // 
            this.TableLayoutPanelAddUpdateProduct.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TableLayoutPanelAddUpdateProduct.ColumnCount = 1;
            this.TableLayoutPanelAddUpdateProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAddUpdateProduct.Controls.Add(this.panelActionButtons, 0, 1);
            this.TableLayoutPanelAddUpdateProduct.Controls.Add(this.panelAddUpdateProductForm, 0, 0);
            this.TableLayoutPanelAddUpdateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAddUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.TableLayoutPanelAddUpdateProduct.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAddUpdateProduct.Name = "TableLayoutPanelAddUpdateProduct";
            this.TableLayoutPanelAddUpdateProduct.RowCount = 2;
            this.TableLayoutPanelAddUpdateProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanelAddUpdateProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanelAddUpdateProduct.Size = new System.Drawing.Size(373, 451);
            this.TableLayoutPanelAddUpdateProduct.TabIndex = 0;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.Controls.Add(this.btnCancel);
            this.panelActionButtons.Controls.Add(this.btnAddUpdateProduct);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActionButtons.Location = new System.Drawing.Point(6, 384);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(361, 61);
            this.panelActionButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(193, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Values.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUpdateProduct
            // 
            this.btnAddUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUpdateProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnAddUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddUpdateProduct.Location = new System.Drawing.Point(23, 14);
            this.btnAddUpdateProduct.Name = "btnAddUpdateProduct";
            this.btnAddUpdateProduct.Size = new System.Drawing.Size(148, 35);
            this.btnAddUpdateProduct.TabIndex = 0;
            this.btnAddUpdateProduct.Values.Text = "SAVE";
            this.btnAddUpdateProduct.Click += new System.EventHandler(this.btnAddUpdateProduct_Click);
            // 
            // panelAddUpdateProductForm
            // 
            this.panelAddUpdateProductForm.BackColor = System.Drawing.Color.Transparent;
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdSuppliedQty);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdSalePrice);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdCostPrice);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdWeight);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdSubCategory);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdCategory);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProdSuppliedQty);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProductSalePrice);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProductCostPrice);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProductWeight);
            this.panelAddUpdateProductForm.Controls.Add(this.ddlProdSubCategory);
            this.panelAddUpdateProductForm.Controls.Add(this.ddlProductCategory);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdDealer);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdBrand);
            this.panelAddUpdateProductForm.Controls.Add(this.ddlProductDealer);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProductBrand);
            this.panelAddUpdateProductForm.Controls.Add(this.txtProductName);
            this.panelAddUpdateProductForm.Controls.Add(this.lblProdName);
            this.panelAddUpdateProductForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUpdateProductForm.Location = new System.Drawing.Point(6, 6);
            this.panelAddUpdateProductForm.Name = "panelAddUpdateProductForm";
            this.panelAddUpdateProductForm.Size = new System.Drawing.Size(361, 369);
            this.panelAddUpdateProductForm.TabIndex = 1;
            // 
            // lblProdSuppliedQty
            // 
            this.lblProdSuppliedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdSuppliedQty.AutoSize = true;
            this.lblProdSuppliedQty.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdSuppliedQty.ForeColor = System.Drawing.Color.White;
            this.lblProdSuppliedQty.Location = new System.Drawing.Point(17, 322);
            this.lblProdSuppliedQty.Name = "lblProdSuppliedQty";
            this.lblProdSuppliedQty.Size = new System.Drawing.Size(119, 18);
            this.lblProdSuppliedQty.TabIndex = 18;
            this.lblProdSuppliedQty.Text = "Supplied Quantity:";
            // 
            // lblProdSalePrice
            // 
            this.lblProdSalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdSalePrice.AutoSize = true;
            this.lblProdSalePrice.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblProdSalePrice.Location = new System.Drawing.Point(68, 285);
            this.lblProdSalePrice.Name = "lblProdSalePrice";
            this.lblProdSalePrice.Size = new System.Drawing.Size(68, 18);
            this.lblProdSalePrice.TabIndex = 17;
            this.lblProdSalePrice.Text = "Sale Price:";
            // 
            // lblProdCostPrice
            // 
            this.lblProdCostPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdCostPrice.AutoSize = true;
            this.lblProdCostPrice.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdCostPrice.ForeColor = System.Drawing.Color.White;
            this.lblProdCostPrice.Location = new System.Drawing.Point(66, 248);
            this.lblProdCostPrice.Name = "lblProdCostPrice";
            this.lblProdCostPrice.Size = new System.Drawing.Size(70, 18);
            this.lblProdCostPrice.TabIndex = 16;
            this.lblProdCostPrice.Text = "Cost Price:";
            // 
            // lblProdWeight
            // 
            this.lblProdWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdWeight.AutoSize = true;
            this.lblProdWeight.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdWeight.ForeColor = System.Drawing.Color.White;
            this.lblProdWeight.Location = new System.Drawing.Point(84, 209);
            this.lblProdWeight.Name = "lblProdWeight";
            this.lblProdWeight.Size = new System.Drawing.Size(52, 18);
            this.lblProdWeight.TabIndex = 15;
            this.lblProdWeight.Text = "Weight:";
            // 
            // lblProdSubCategory
            // 
            this.lblProdSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdSubCategory.AutoSize = true;
            this.lblProdSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdSubCategory.ForeColor = System.Drawing.Color.White;
            this.lblProdSubCategory.Location = new System.Drawing.Point(48, 172);
            this.lblProdSubCategory.Name = "lblProdSubCategory";
            this.lblProdSubCategory.Size = new System.Drawing.Size(88, 18);
            this.lblProdSubCategory.TabIndex = 14;
            this.lblProdSubCategory.Text = "SubCategory:";
            // 
            // lblProdCategory
            // 
            this.lblProdCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdCategory.AutoSize = true;
            this.lblProdCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdCategory.ForeColor = System.Drawing.Color.White;
            this.lblProdCategory.Location = new System.Drawing.Point(71, 135);
            this.lblProdCategory.Name = "lblProdCategory";
            this.lblProdCategory.Size = new System.Drawing.Size(65, 18);
            this.lblProdCategory.TabIndex = 13;
            this.lblProdCategory.Text = "Category:";
            // 
            // txtProdSuppliedQty
            // 
            this.txtProdSuppliedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdSuppliedQty.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProdSuppliedQty.Location = new System.Drawing.Point(154, 316);
            this.txtProdSuppliedQty.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtProdSuppliedQty.Name = "txtProdSuppliedQty";
            this.txtProdSuppliedQty.Size = new System.Drawing.Size(185, 24);
            this.txtProdSuppliedQty.TabIndex = 12;
            this.txtProdSuppliedQty.ThousandsSeparator = true;
            // 
            // txtProductSalePrice
            // 
            this.txtProductSalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSalePrice.DecimalPlaces = 2;
            this.txtProductSalePrice.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProductSalePrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProductSalePrice.Location = new System.Drawing.Point(154, 279);
            this.txtProductSalePrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtProductSalePrice.Name = "txtProductSalePrice";
            this.txtProductSalePrice.Size = new System.Drawing.Size(185, 24);
            this.txtProductSalePrice.TabIndex = 11;
            this.txtProductSalePrice.ThousandsSeparator = true;
            // 
            // txtProductCostPrice
            // 
            this.txtProductCostPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCostPrice.DecimalPlaces = 2;
            this.txtProductCostPrice.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProductCostPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProductCostPrice.Location = new System.Drawing.Point(154, 242);
            this.txtProductCostPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtProductCostPrice.Name = "txtProductCostPrice";
            this.txtProductCostPrice.Size = new System.Drawing.Size(185, 24);
            this.txtProductCostPrice.TabIndex = 10;
            this.txtProductCostPrice.ThousandsSeparator = true;
            // 
            // txtProductWeight
            // 
            this.txtProductWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductWeight.DecimalPlaces = 2;
            this.txtProductWeight.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProductWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProductWeight.Location = new System.Drawing.Point(154, 203);
            this.txtProductWeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtProductWeight.Name = "txtProductWeight";
            this.txtProductWeight.Size = new System.Drawing.Size(185, 24);
            this.txtProductWeight.TabIndex = 9;
            this.txtProductWeight.ThousandsSeparator = true;
            // 
            // ddlProdSubCategory
            // 
            this.ddlProdSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlProdSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlProdSubCategory.FormattingEnabled = true;
            this.ddlProdSubCategory.Location = new System.Drawing.Point(154, 166);
            this.ddlProdSubCategory.Name = "ddlProdSubCategory";
            this.ddlProdSubCategory.Size = new System.Drawing.Size(185, 24);
            this.ddlProdSubCategory.TabIndex = 8;
            // 
            // ddlProductCategory
            // 
            this.ddlProductCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlProductCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlProductCategory.FormattingEnabled = true;
            this.ddlProductCategory.Location = new System.Drawing.Point(154, 129);
            this.ddlProductCategory.MaxDropDownItems = 20;
            this.ddlProductCategory.Name = "ddlProductCategory";
            this.ddlProductCategory.Size = new System.Drawing.Size(185, 24);
            this.ddlProductCategory.TabIndex = 7;
            this.ddlProductCategory.Text = "Select a product category";
            this.ddlProductCategory.SelectedIndexChanged += new System.EventHandler(this.ddlProductCategory_SelectedIndexChanged);
            // 
            // lblProdDealer
            // 
            this.lblProdDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdDealer.AutoSize = true;
            this.lblProdDealer.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdDealer.ForeColor = System.Drawing.Color.White;
            this.lblProdDealer.Location = new System.Drawing.Point(86, 98);
            this.lblProdDealer.Name = "lblProdDealer";
            this.lblProdDealer.Size = new System.Drawing.Size(50, 18);
            this.lblProdDealer.TabIndex = 6;
            this.lblProdDealer.Text = "Dealer:";
            // 
            // lblProdBrand
            // 
            this.lblProdBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdBrand.AutoSize = true;
            this.lblProdBrand.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdBrand.ForeColor = System.Drawing.Color.White;
            this.lblProdBrand.Location = new System.Drawing.Point(89, 62);
            this.lblProdBrand.Name = "lblProdBrand";
            this.lblProdBrand.Size = new System.Drawing.Size(47, 18);
            this.lblProdBrand.TabIndex = 5;
            this.lblProdBrand.Text = "Brand:";
            // 
            // ddlProductDealer
            // 
            this.ddlProductDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlProductDealer.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlProductDealer.FormattingEnabled = true;
            this.ddlProductDealer.Location = new System.Drawing.Point(154, 92);
            this.ddlProductDealer.MaxDropDownItems = 40;
            this.ddlProductDealer.Name = "ddlProductDealer";
            this.ddlProductDealer.Size = new System.Drawing.Size(185, 24);
            this.ddlProductDealer.TabIndex = 4;
            this.ddlProductDealer.Text = "Select the product dealer";
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProductBrand.Location = new System.Drawing.Point(154, 56);
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(185, 24);
            this.txtProductBrand.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtProductName.Location = new System.Drawing.Point(154, 21);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 24);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProdName
            // 
            this.lblProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblProdName.ForeColor = System.Drawing.Color.White;
            this.lblProdName.Location = new System.Drawing.Point(90, 27);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(46, 18);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "Name:";
            // 
            // AddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(373, 451);
            this.Controls.Add(this.TableLayoutPanelAddUpdateProduct);
            this.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Product";
            this.TableLayoutPanelAddUpdateProduct.ResumeLayout(false);
            this.panelActionButtons.ResumeLayout(false);
            this.panelAddUpdateProductForm.ResumeLayout(false);
            this.panelAddUpdateProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdSuppliedQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel panelActionButtons;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanelAddUpdateProduct;
        private System.Windows.Forms.Panel panelAddUpdateProductForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddUpdateProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.TextBox txtProductBrand;
        internal System.Windows.Forms.ComboBox ddlProductDealer;
        internal System.Windows.Forms.Label lblProdDealer;
        internal System.Windows.Forms.ComboBox ddlProductCategory;
        internal System.Windows.Forms.ComboBox ddlProdSubCategory;
        internal System.Windows.Forms.NumericUpDown txtProductWeight;
        internal System.Windows.Forms.Label lblProdName;
        internal System.Windows.Forms.Label lblProdBrand;
        private System.Windows.Forms.NumericUpDown txtProductCostPrice;
        private System.Windows.Forms.NumericUpDown txtProductSalePrice;
        internal System.Windows.Forms.Label lblProdCategory;
        internal System.Windows.Forms.Label lblProdWeight;
        internal System.Windows.Forms.Label lblProdSubCategory;
        private System.Windows.Forms.Label lblProdSalePrice;
        private System.Windows.Forms.Label lblProdCostPrice;
        internal System.Windows.Forms.NumericUpDown txtProdSuppliedQty;
        internal System.Windows.Forms.Label lblProdSuppliedQty;
    }
}