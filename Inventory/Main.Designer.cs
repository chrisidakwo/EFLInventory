namespace Inventory {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainView_statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblAuthText = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainView_menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventorySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportMSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsStockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBrandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTransactionsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdViewInventorySummary = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.productName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productStock = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.unitMeasurement = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.salePrice = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productTotalSales = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.mainView_splitContainer = new System.Windows.Forms.SplitContainer();
            this.TablePanelSummaries = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalesTodayAmt = new System.Windows.Forms.Label();
            this.lblSalesTodayHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSalesMonthAmt = new System.Windows.Forms.Label();
            this.lblSalesMonthHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalesHalfYearAmt = new System.Windows.Forms.Label();
            this.lblSalesHalfYearHeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEntireStockValueHeader = new System.Windows.Forms.Label();
            this.lblEntireStockValueAmt = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainView_statusStrip.SuspendLayout();
            this.mainView_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewInventorySummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView_splitContainer)).BeginInit();
            this.mainView_splitContainer.Panel1.SuspendLayout();
            this.mainView_splitContainer.Panel2.SuspendLayout();
            this.mainView_splitContainer.SuspendLayout();
            this.TablePanelSummaries.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainView_statusStrip
            // 
            this.mainView_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAuthText});
            this.mainView_statusStrip.Location = new System.Drawing.Point(0, 442);
            this.mainView_statusStrip.Name = "mainView_statusStrip";
            this.mainView_statusStrip.Size = new System.Drawing.Size(878, 22);
            this.mainView_statusStrip.TabIndex = 1;
            // 
            // lblAuthText
            // 
            this.lblAuthText.Name = "lblAuthText";
            this.lblAuthText.Size = new System.Drawing.Size(77, 17);
            this.lblAuthText.Text = "Logged in as:";
            // 
            // mainView_menuStrip
            // 
            this.mainView_menuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainView_menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainView_menuStrip.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.mainView_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.dealersToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainView_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainView_menuStrip.Name = "mainView_menuStrip";
            this.mainView_menuStrip.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.mainView_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainView_menuStrip.Size = new System.Drawing.Size(878, 34);
            this.mainView_menuStrip.TabIndex = 0;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingsToolStripMenuItem.Image")));
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventorySummaryToolStripMenuItem,
            this.generateReportMSExcelToolStripMenuItem,
            this.generateReportCSVToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // inventorySummaryToolStripMenuItem
            // 
            this.inventorySummaryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventorySummaryToolStripMenuItem.Image")));
            this.inventorySummaryToolStripMenuItem.Name = "inventorySummaryToolStripMenuItem";
            this.inventorySummaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.inventorySummaryToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.inventorySummaryToolStripMenuItem.Text = "Inventory Summary";
            this.inventorySummaryToolStripMenuItem.Click += new System.EventHandler(this.inventorySummaryToolStripMenuItem_Click);
            // 
            // generateReportMSExcelToolStripMenuItem
            // 
            this.generateReportMSExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generateReportMSExcelToolStripMenuItem.Image")));
            this.generateReportMSExcelToolStripMenuItem.Name = "generateReportMSExcelToolStripMenuItem";
            this.generateReportMSExcelToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.generateReportMSExcelToolStripMenuItem.Text = "Generate Report (MS Excel)";
            this.generateReportMSExcelToolStripMenuItem.Click += new System.EventHandler(this.generateReportMSExcelToolStripMenuItem_Click);
            // 
            // generateReportCSVToolStripMenuItem
            // 
            this.generateReportCSVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generateReportCSVToolStripMenuItem.Image")));
            this.generateReportCSVToolStripMenuItem.Name = "generateReportCSVToolStripMenuItem";
            this.generateReportCSVToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.generateReportCSVToolStripMenuItem.Text = "Generate Report (CSV)";
            this.generateReportCSVToolStripMenuItem.Click += new System.EventHandler(this.generateReportCSVToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.subCategoryToolStripMenuItem,
            this.productToolStripMenuItem1});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.productToolStripMenuItem.Text = "Products";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryToolStripMenuItem.Image")));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subCategoryToolStripMenuItem.Image")));
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.subCategoryToolStripMenuItem.Text = "SubCategory";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.viewProductsToolStripMenuItem,
            this.productsStockEntryToolStripMenuItem,
            this.sellProductsToolStripMenuItem});
            this.productToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem1.Image")));
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.productToolStripMenuItem1.Text = "Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addProductToolStripMenuItem.Image")));
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.addProductToolStripMenuItem.Text = "Add/Update Products";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewProductsToolStripMenuItem.Image")));
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // productsStockEntryToolStripMenuItem
            // 
            this.productsStockEntryToolStripMenuItem.Image = global::Inventory.Properties.Resources.StockEntry;
            this.productsStockEntryToolStripMenuItem.Name = "productsStockEntryToolStripMenuItem";
            this.productsStockEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.productsStockEntryToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.productsStockEntryToolStripMenuItem.Text = "Products Stock Entry";
            this.productsStockEntryToolStripMenuItem.Click += new System.EventHandler(this.productStockEntryToolStripMenuItem_Click);
            // 
            // sellProductsToolStripMenuItem
            // 
            this.sellProductsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sellProductsToolStripMenuItem.Image")));
            this.sellProductsToolStripMenuItem.Name = "sellProductsToolStripMenuItem";
            this.sellProductsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sellProductsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sellProductsToolStripMenuItem.Text = "Sell Products";
            this.sellProductsToolStripMenuItem.Click += new System.EventHandler(this.sellProductToolStripMenuItem_Click);
            // 
            // dealersToolStripMenuItem
            // 
            this.dealersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDealersToolStripMenuItem,
            this.viewBrandsToolStripMenuItem});
            this.dealersToolStripMenuItem.Name = "dealersToolStripMenuItem";
            this.dealersToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.dealersToolStripMenuItem.Text = "Dealers";
            // 
            // viewDealersToolStripMenuItem
            // 
            this.viewDealersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewDealersToolStripMenuItem.Image")));
            this.viewDealersToolStripMenuItem.Name = "viewDealersToolStripMenuItem";
            this.viewDealersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.viewDealersToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewDealersToolStripMenuItem.Text = "View Dealers";
            this.viewDealersToolStripMenuItem.Click += new System.EventHandler(this.viewDealersToolStripMenuItem_Click);
            // 
            // viewBrandsToolStripMenuItem
            // 
            this.viewBrandsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBrandsToolStripMenuItem.Image")));
            this.viewBrandsToolStripMenuItem.Name = "viewBrandsToolStripMenuItem";
            this.viewBrandsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewBrandsToolStripMenuItem.Text = "Brands";
            this.viewBrandsToolStripMenuItem.Click += new System.EventHandler(this.viewBrandsToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTransactionsToolStripMenuItem,
            this.downloadTransactionsReportToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewTransactionsToolStripMenuItem.Image")));
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            this.viewTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionsToolStripMenuItem_Click);
            // 
            // downloadTransactionsReportToolStripMenuItem
            // 
            this.downloadTransactionsReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadTransactionsReportToolStripMenuItem.Image")));
            this.downloadTransactionsReportToolStripMenuItem.Name = "downloadTransactionsReportToolStripMenuItem";
            this.downloadTransactionsReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.downloadTransactionsReportToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.downloadTransactionsReportToolStripMenuItem.Text = "Generate Reports";
            this.downloadTransactionsReportToolStripMenuItem.Click += new System.EventHandler(this.downloadTransactionsReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutUsToolStripMenuItem.Text = "About";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // grdViewInventorySummary
            // 
            this.grdViewInventorySummary.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.grdViewInventorySummary.AllowUserToAddRows = false;
            this.grdViewInventorySummary.AllowUserToDeleteRows = false;
            this.grdViewInventorySummary.AllowUserToResizeRows = false;
            this.grdViewInventorySummary.ColumnHeadersHeight = 40;
            this.grdViewInventorySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productStock,
            this.unitMeasurement,
            this.salePrice,
            this.productTotalSales});
            this.grdViewInventorySummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewInventorySummary.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.grdViewInventorySummary.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewInventorySummary.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewInventorySummary.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewInventorySummary.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewInventorySummary.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewInventorySummary.Location = new System.Drawing.Point(0, 0);
            this.grdViewInventorySummary.MultiSelect = false;
            this.grdViewInventorySummary.Name = "grdViewInventorySummary";
            this.grdViewInventorySummary.ReadOnly = true;
            this.grdViewInventorySummary.RowTemplate.ReadOnly = true;
            this.grdViewInventorySummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewInventorySummary.Size = new System.Drawing.Size(717, 408);
            this.grdViewInventorySummary.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "VariationName";
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productName.Width = 251;
            // 
            // productStock
            // 
            this.productStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productStock.DataPropertyName = "availableStock";
            this.productStock.HeaderText = "Available Stock";
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productStock.Width = 112;
            // 
            // unitMeasurement
            // 
            this.unitMeasurement.DataPropertyName = "unit_measurement";
            this.unitMeasurement.HeaderText = "Unit Measurement";
            this.unitMeasurement.Name = "unitMeasurement";
            this.unitMeasurement.ReadOnly = true;
            this.unitMeasurement.Width = 110;
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "retailPrice";
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            this.salePrice.Width = 90;
            // 
            // productTotalSales
            // 
            this.productTotalSales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productTotalSales.DataPropertyName = "totalSales";
            this.productTotalSales.HeaderText = "Total Sales";
            this.productTotalSales.Name = "productTotalSales";
            this.productTotalSales.ReadOnly = true;
            this.productTotalSales.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productTotalSales.Width = 113;
            // 
            // mainView_splitContainer
            // 
            this.mainView_splitContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainView_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainView_splitContainer.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.mainView_splitContainer.ForeColor = System.Drawing.Color.White;
            this.mainView_splitContainer.IsSplitterFixed = true;
            this.mainView_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainView_splitContainer.Name = "mainView_splitContainer";
            // 
            // mainView_splitContainer.Panel1
            // 
            this.mainView_splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.mainView_splitContainer.Panel1.Controls.Add(this.TablePanelSummaries);
            this.mainView_splitContainer.Panel1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mainView_splitContainer.Panel2
            // 
            this.mainView_splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.mainView_splitContainer.Panel2.Controls.Add(this.grdViewInventorySummary);
            this.mainView_splitContainer.Panel2.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView_splitContainer.Panel2.ForeColor = System.Drawing.Color.White;
            this.mainView_splitContainer.Size = new System.Drawing.Size(878, 408);
            this.mainView_splitContainer.SplitterDistance = 160;
            this.mainView_splitContainer.SplitterWidth = 1;
            this.mainView_splitContainer.TabIndex = 4;
            // 
            // TablePanelSummaries
            // 
            this.TablePanelSummaries.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TablePanelSummaries.ColumnCount = 1;
            this.TablePanelSummaries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelSummaries.Controls.Add(this.panel1, 0, 0);
            this.TablePanelSummaries.Controls.Add(this.panel2, 0, 1);
            this.TablePanelSummaries.Controls.Add(this.panel3, 0, 2);
            this.TablePanelSummaries.Controls.Add(this.panel4, 0, 3);
            this.TablePanelSummaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelSummaries.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.TablePanelSummaries.Location = new System.Drawing.Point(0, 0);
            this.TablePanelSummaries.Name = "TablePanelSummaries";
            this.TablePanelSummaries.RowCount = 4;
            this.TablePanelSummaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelSummaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelSummaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelSummaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelSummaries.Size = new System.Drawing.Size(160, 408);
            this.TablePanelSummaries.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSalesTodayAmt);
            this.panel1.Controls.Add(this.lblSalesTodayHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblSalesTodayAmt
            // 
            this.lblSalesTodayAmt.Location = new System.Drawing.Point(9, 64);
            this.lblSalesTodayAmt.Name = "lblSalesTodayAmt";
            this.lblSalesTodayAmt.Size = new System.Drawing.Size(125, 22);
            this.lblSalesTodayAmt.TabIndex = 1;
            this.lblSalesTodayAmt.Text = "N25,000.00";
            // 
            // lblSalesTodayHeader
            // 
            this.lblSalesTodayHeader.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.lblSalesTodayHeader.Location = new System.Drawing.Point(8, 11);
            this.lblSalesTodayHeader.Name = "lblSalesTodayHeader";
            this.lblSalesTodayHeader.Size = new System.Drawing.Size(120, 53);
            this.lblSalesTodayHeader.TabIndex = 0;
            this.lblSalesTodayHeader.Text = "Total Sales for Today:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSalesMonthAmt);
            this.panel2.Controls.Add(this.lblSalesMonthHeader);
            this.panel2.Location = new System.Drawing.Point(6, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 92);
            this.panel2.TabIndex = 1;
            // 
            // lblSalesMonthAmt
            // 
            this.lblSalesMonthAmt.Location = new System.Drawing.Point(9, 64);
            this.lblSalesMonthAmt.Name = "lblSalesMonthAmt";
            this.lblSalesMonthAmt.Size = new System.Drawing.Size(128, 21);
            this.lblSalesMonthAmt.TabIndex = 1;
            this.lblSalesMonthAmt.Text = "N173,420.00";
            // 
            // lblSalesMonthHeader
            // 
            this.lblSalesMonthHeader.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.lblSalesMonthHeader.Location = new System.Drawing.Point(8, 10);
            this.lblSalesMonthHeader.Name = "lblSalesMonthHeader";
            this.lblSalesMonthHeader.Size = new System.Drawing.Size(129, 49);
            this.lblSalesMonthHeader.TabIndex = 0;
            this.lblSalesMonthHeader.Text = "Total Sales for the Month:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSalesHalfYearAmt);
            this.panel3.Controls.Add(this.lblSalesHalfYearHeader);
            this.panel3.Location = new System.Drawing.Point(6, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 92);
            this.panel3.TabIndex = 2;
            // 
            // lblSalesHalfYearAmt
            // 
            this.lblSalesHalfYearAmt.Location = new System.Drawing.Point(9, 64);
            this.lblSalesHalfYearAmt.Name = "lblSalesHalfYearAmt";
            this.lblSalesHalfYearAmt.Size = new System.Drawing.Size(124, 23);
            this.lblSalesHalfYearAmt.TabIndex = 1;
            this.lblSalesHalfYearAmt.Text = "N2,569,045.00";
            // 
            // lblSalesHalfYearHeader
            // 
            this.lblSalesHalfYearHeader.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.lblSalesHalfYearHeader.Location = new System.Drawing.Point(8, 11);
            this.lblSalesHalfYearHeader.Name = "lblSalesHalfYearHeader";
            this.lblSalesHalfYearHeader.Size = new System.Drawing.Size(124, 49);
            this.lblSalesHalfYearHeader.TabIndex = 0;
            this.lblSalesHalfYearHeader.Text = "Total Sales (Half Year):";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblEntireStockValueHeader);
            this.panel4.Controls.Add(this.lblEntireStockValueAmt);
            this.panel4.Location = new System.Drawing.Point(6, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 93);
            this.panel4.TabIndex = 3;
            // 
            // lblEntireStockValueHeader
            // 
            this.lblEntireStockValueHeader.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntireStockValueHeader.Location = new System.Drawing.Point(8, 11);
            this.lblEntireStockValueHeader.Name = "lblEntireStockValueHeader";
            this.lblEntireStockValueHeader.Size = new System.Drawing.Size(99, 50);
            this.lblEntireStockValueHeader.TabIndex = 1;
            this.lblEntireStockValueHeader.Text = "Value of Stocks:";
            // 
            // lblEntireStockValueAmt
            // 
            this.lblEntireStockValueAmt.Location = new System.Drawing.Point(9, 65);
            this.lblEntireStockValueAmt.Name = "lblEntireStockValueAmt";
            this.lblEntireStockValueAmt.Size = new System.Drawing.Size(128, 24);
            this.lblEntireStockValueAmt.TabIndex = 0;
            this.lblEntireStockValueAmt.Text = "N3,569,020.00";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.mainPanel.Controls.Add(this.mainView_splitContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 34);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(878, 408);
            this.mainPanel.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(878, 464);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainView_statusStrip);
            this.Controls.Add(this.mainView_menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainView_menuStrip;
            this.MaximumSize = new System.Drawing.Size(1027, 579);
            this.MinimumSize = new System.Drawing.Size(894, 503);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EFL Inventory Management";
            this.mainView_statusStrip.ResumeLayout(false);
            this.mainView_statusStrip.PerformLayout();
            this.mainView_menuStrip.ResumeLayout(false);
            this.mainView_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewInventorySummary)).EndInit();
            this.mainView_splitContainer.Panel1.ResumeLayout(false);
            this.mainView_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainView_splitContainer)).EndInit();
            this.mainView_splitContainer.ResumeLayout(false);
            this.TablePanelSummaries.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.StatusStrip mainView_statusStrip;
        private System.Windows.Forms.MenuStrip mainView_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventorySummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportMSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsStockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel lblAuthText;
        private System.Windows.Forms.ToolStripMenuItem downloadTransactionsReportToolStripMenuItem;
        internal ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdViewInventorySummary;
        public System.Windows.Forms.SplitContainer mainView_splitContainer;
        private System.Windows.Forms.TableLayoutPanel TablePanelSummaries;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblSalesTodayAmt;
        public System.Windows.Forms.Label lblSalesTodayHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblSalesMonthAmt;
        public System.Windows.Forms.Label lblSalesMonthHeader;
        public System.Windows.Forms.Label lblSalesHalfYearHeader;
        public System.Windows.Forms.Label lblSalesHalfYearAmt;
        public System.Windows.Forms.Label lblEntireStockValueHeader;
        public System.Windows.Forms.Label lblEntireStockValueAmt;
        private System.Windows.Forms.ToolStripMenuItem generateReportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBrandsToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productStock;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn unitMeasurement;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn salePrice;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn productTotalSales;
    }
}

