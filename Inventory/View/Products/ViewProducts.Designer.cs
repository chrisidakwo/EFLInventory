using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Inventory.View.Products {
    partial class ViewProducts {
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
            this.grdViewAllProducts = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.TablePanelViewProducts = new System.Windows.Forms.TableLayoutPanel();
            this.panelProductsGridView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablePanelFilterControls = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearchByName = new System.Windows.Forms.Panel();
            this.txtSearchProductByName = new System.Windows.Forms.TextBox();
            this.lblSearchProductByName = new System.Windows.Forms.Label();
            this.btnSearchProductByName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelSearchByBrand = new System.Windows.Forms.Panel();
            this.lblSearchProductsByBrand = new System.Windows.Forms.Label();
            this.txtSearchProductsByBrand = new System.Windows.Forms.TextBox();
            this.btnSearchProductsByBrand = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelSortByColumn = new System.Windows.Forms.Panel();
            this.ddlSortProducts = new System.Windows.Forms.ComboBox();
            this.ddlSortOrder = new System.Windows.Forms.ComboBox();
            this.lblSortProducts = new System.Windows.Forms.Label();
            this.panelResetFilters = new System.Windows.Forms.Panel();
            this.btnResetSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerateReportAsExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGenerateReportAsCSV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblReportFilename = new System.Windows.Forms.Label();
            this.txtReportFilename = new System.Windows.Forms.TextBox();
            this._variationId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.variationName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productBrand = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productCategory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productSubCategory = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productStock = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.productSalePrice = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllProducts)).BeginInit();
            this.TablePanelViewProducts.SuspendLayout();
            this.panelProductsGridView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TablePanelFilterControls.SuspendLayout();
            this.panelSearchByName.SuspendLayout();
            this.panelSearchByBrand.SuspendLayout();
            this.panelSortByColumn.SuspendLayout();
            this.panelResetFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewAllProducts
            // 
            this.grdViewAllProducts.AllowUserToAddRows = false;
            this.grdViewAllProducts.AllowUserToDeleteRows = false;
            this.grdViewAllProducts.AllowUserToResizeRows = false;
            this.grdViewAllProducts.ColumnHeadersHeight = 40;
            this.grdViewAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._variationId,
            this.variationName,
            this.productBrand,
            this.productCategory,
            this.productSubCategory,
            this.productStock,
            this.productSalePrice});
            this.grdViewAllProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewAllProducts.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewAllProducts.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewAllProducts.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllProducts.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllProducts.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllProducts.Location = new System.Drawing.Point(0, 0);
            this.grdViewAllProducts.MultiSelect = false;
            this.grdViewAllProducts.Name = "grdViewAllProducts";
            this.grdViewAllProducts.ReadOnly = true;
            this.grdViewAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewAllProducts.Size = new System.Drawing.Size(862, 230);
            this.grdViewAllProducts.TabIndex = 0;
            // 
            // TablePanelViewProducts
            // 
            this.TablePanelViewProducts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TablePanelViewProducts.ColumnCount = 1;
            this.TablePanelViewProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelViewProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanelViewProducts.Controls.Add(this.panelProductsGridView, 0, 1);
            this.TablePanelViewProducts.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TablePanelViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelViewProducts.Location = new System.Drawing.Point(0, 0);
            this.TablePanelViewProducts.Name = "TablePanelViewProducts";
            this.TablePanelViewProducts.RowCount = 2;
            this.TablePanelViewProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TablePanelViewProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanelViewProducts.Size = new System.Drawing.Size(878, 408);
            this.TablePanelViewProducts.TabIndex = 1;
            // 
            // panelProductsGridView
            // 
            this.panelProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProductsGridView.Controls.Add(this.grdViewAllProducts);
            this.panelProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsGridView.Location = new System.Drawing.Point(6, 168);
            this.panelProductsGridView.Name = "panelProductsGridView";
            this.panelProductsGridView.Size = new System.Drawing.Size(866, 234);
            this.panelProductsGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.9007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09931F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 153);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TablePanelFilterControls);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search/Filter Products";
            // 
            // TablePanelFilterControls
            // 
            this.TablePanelFilterControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelFilterControls.ColumnCount = 4;
            this.TablePanelFilterControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelFilterControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelFilterControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelFilterControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablePanelFilterControls.Controls.Add(this.panelSearchByName, 0, 0);
            this.TablePanelFilterControls.Controls.Add(this.panelSearchByBrand, 1, 0);
            this.TablePanelFilterControls.Controls.Add(this.panelSortByColumn, 2, 0);
            this.TablePanelFilterControls.Controls.Add(this.panelResetFilters, 3, 0);
            this.TablePanelFilterControls.Location = new System.Drawing.Point(19, 32);
            this.TablePanelFilterControls.Name = "TablePanelFilterControls";
            this.TablePanelFilterControls.RowCount = 1;
            this.TablePanelFilterControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelFilterControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.TablePanelFilterControls.Size = new System.Drawing.Size(569, 99);
            this.TablePanelFilterControls.TabIndex = 1;
            // 
            // panelSearchByName
            // 
            this.panelSearchByName.Controls.Add(this.txtSearchProductByName);
            this.panelSearchByName.Controls.Add(this.lblSearchProductByName);
            this.panelSearchByName.Controls.Add(this.btnSearchProductByName);
            this.panelSearchByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchByName.Location = new System.Drawing.Point(3, 3);
            this.panelSearchByName.Name = "panelSearchByName";
            this.panelSearchByName.Size = new System.Drawing.Size(136, 93);
            this.panelSearchByName.TabIndex = 0;
            // 
            // txtSearchProductByName
            // 
            this.txtSearchProductByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProductByName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSearchProductByName.Location = new System.Drawing.Point(14, 25);
            this.txtSearchProductByName.Name = "txtSearchProductByName";
            this.txtSearchProductByName.Size = new System.Drawing.Size(107, 24);
            this.txtSearchProductByName.TabIndex = 1;
            // 
            // lblSearchProductByName
            // 
            this.lblSearchProductByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchProductByName.AutoSize = true;
            this.lblSearchProductByName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSearchProductByName.Location = new System.Drawing.Point(11, 4);
            this.lblSearchProductByName.Name = "lblSearchProductByName";
            this.lblSearchProductByName.Size = new System.Drawing.Size(106, 18);
            this.lblSearchProductByName.TabIndex = 0;
            this.lblSearchProductByName.Text = "Search by name:";
            // 
            // btnSearchProductByName
            // 
            this.btnSearchProductByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProductByName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnSearchProductByName.Location = new System.Drawing.Point(14, 55);
            this.btnSearchProductByName.Name = "btnSearchProductByName";
            this.btnSearchProductByName.Size = new System.Drawing.Size(106, 32);
            this.btnSearchProductByName.TabIndex = 2;
            this.btnSearchProductByName.Values.Text = "SEARCH";
            // 
            // panelSearchByBrand
            // 
            this.panelSearchByBrand.Controls.Add(this.lblSearchProductsByBrand);
            this.panelSearchByBrand.Controls.Add(this.txtSearchProductsByBrand);
            this.panelSearchByBrand.Controls.Add(this.btnSearchProductsByBrand);
            this.panelSearchByBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchByBrand.Location = new System.Drawing.Point(145, 3);
            this.panelSearchByBrand.Name = "panelSearchByBrand";
            this.panelSearchByBrand.Size = new System.Drawing.Size(136, 93);
            this.panelSearchByBrand.TabIndex = 1;
            // 
            // lblSearchProductsByBrand
            // 
            this.lblSearchProductsByBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchProductsByBrand.AutoSize = true;
            this.lblSearchProductsByBrand.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSearchProductsByBrand.Location = new System.Drawing.Point(9, 4);
            this.lblSearchProductsByBrand.Name = "lblSearchProductsByBrand";
            this.lblSearchProductsByBrand.Size = new System.Drawing.Size(108, 18);
            this.lblSearchProductsByBrand.TabIndex = 3;
            this.lblSearchProductsByBrand.Text = "Search by brand:";
            // 
            // txtSearchProductsByBrand
            // 
            this.txtSearchProductsByBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProductsByBrand.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSearchProductsByBrand.Location = new System.Drawing.Point(11, 25);
            this.txtSearchProductsByBrand.Name = "txtSearchProductsByBrand";
            this.txtSearchProductsByBrand.Size = new System.Drawing.Size(103, 24);
            this.txtSearchProductsByBrand.TabIndex = 4;
            // 
            // btnSearchProductsByBrand
            // 
            this.btnSearchProductsByBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProductsByBrand.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnSearchProductsByBrand.Location = new System.Drawing.Point(11, 55);
            this.btnSearchProductsByBrand.Name = "btnSearchProductsByBrand";
            this.btnSearchProductsByBrand.Size = new System.Drawing.Size(103, 32);
            this.btnSearchProductsByBrand.TabIndex = 5;
            this.btnSearchProductsByBrand.Values.Text = "SEARCH";
            // 
            // panelSortByColumn
            // 
            this.panelSortByColumn.Controls.Add(this.ddlSortProducts);
            this.panelSortByColumn.Controls.Add(this.ddlSortOrder);
            this.panelSortByColumn.Controls.Add(this.lblSortProducts);
            this.panelSortByColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSortByColumn.Location = new System.Drawing.Point(287, 3);
            this.panelSortByColumn.Name = "panelSortByColumn";
            this.panelSortByColumn.Size = new System.Drawing.Size(136, 93);
            this.panelSortByColumn.TabIndex = 2;
            // 
            // ddlSortProducts
            // 
            this.ddlSortProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortProducts.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlSortProducts.FormattingEnabled = true;
            this.ddlSortProducts.Location = new System.Drawing.Point(12, 25);
            this.ddlSortProducts.Name = "ddlSortProducts";
            this.ddlSortProducts.Size = new System.Drawing.Size(107, 24);
            this.ddlSortProducts.TabIndex = 8;
            // 
            // ddlSortOrder
            // 
            this.ddlSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortOrder.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlSortOrder.FormattingEnabled = true;
            this.ddlSortOrder.Location = new System.Drawing.Point(12, 63);
            this.ddlSortOrder.Name = "ddlSortOrder";
            this.ddlSortOrder.Size = new System.Drawing.Size(107, 24);
            this.ddlSortOrder.TabIndex = 9;
            // 
            // lblSortProducts
            // 
            this.lblSortProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortProducts.AutoSize = true;
            this.lblSortProducts.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSortProducts.Location = new System.Drawing.Point(9, 4);
            this.lblSortProducts.Name = "lblSortProducts";
            this.lblSortProducts.Size = new System.Drawing.Size(54, 18);
            this.lblSortProducts.TabIndex = 7;
            this.lblSortProducts.Text = "Sort by:";
            // 
            // panelResetFilters
            // 
            this.panelResetFilters.Controls.Add(this.btnResetSearch);
            this.panelResetFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResetFilters.Location = new System.Drawing.Point(429, 3);
            this.panelResetFilters.Name = "panelResetFilters";
            this.panelResetFilters.Size = new System.Drawing.Size(137, 93);
            this.panelResetFilters.TabIndex = 3;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSearch.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnResetSearch.Location = new System.Drawing.Point(29, 55);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(105, 32);
            this.btnResetSearch.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnResetSearch.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnResetSearch.TabIndex = 6;
            this.btnResetSearch.Values.Text = "RESET";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.lblReportFilename);
            this.groupBox2.Controls.Add(this.txtReportFilename);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(616, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Report";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnGenerateReportAsExcel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerateReportAsCSV, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 38);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnGenerateReportAsExcel
            // 
            this.btnGenerateReportAsExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReportAsExcel.Location = new System.Drawing.Point(3, 3);
            this.btnGenerateReportAsExcel.Name = "btnGenerateReportAsExcel";
            this.btnGenerateReportAsExcel.Size = new System.Drawing.Size(100, 32);
            this.btnGenerateReportAsExcel.TabIndex = 0;
            this.btnGenerateReportAsExcel.Values.Text = "AS EXCEL";
            this.btnGenerateReportAsExcel.Click += new System.EventHandler(this.btnGenerateReportAsExcel_Click);
            // 
            // btnGenerateReportAsCSV
            // 
            this.btnGenerateReportAsCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReportAsCSV.Location = new System.Drawing.Point(109, 3);
            this.btnGenerateReportAsCSV.Name = "btnGenerateReportAsCSV";
            this.btnGenerateReportAsCSV.Size = new System.Drawing.Size(100, 32);
            this.btnGenerateReportAsCSV.TabIndex = 1;
            this.btnGenerateReportAsCSV.Values.Text = "AS CSV";
            this.btnGenerateReportAsCSV.Click += new System.EventHandler(this.btnGenerateReportAsCSV_Click);
            // 
            // lblReportFilename
            // 
            this.lblReportFilename.AutoSize = true;
            this.lblReportFilename.Location = new System.Drawing.Point(17, 39);
            this.lblReportFilename.Name = "lblReportFilename";
            this.lblReportFilename.Size = new System.Drawing.Size(66, 18);
            this.lblReportFilename.TabIndex = 1;
            this.lblReportFilename.Text = "Filename:";
            // 
            // txtReportFilename
            // 
            this.txtReportFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportFilename.Location = new System.Drawing.Point(20, 60);
            this.txtReportFilename.Name = "txtReportFilename";
            this.txtReportFilename.Size = new System.Drawing.Size(206, 24);
            this.txtReportFilename.TabIndex = 0;
            // 
            // _variationId
            // 
            this._variationId.DataPropertyName = "VariationID";
            this._variationId.HeaderText = "ID";
            this._variationId.Name = "_variationId";
            this._variationId.ReadOnly = true;
            this._variationId.Width = 50;
            // 
            // variationName
            // 
            this.variationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.variationName.DataPropertyName = "VariationName";
            this.variationName.HeaderText = "Variation Name";
            this.variationName.Name = "variationName";
            this.variationName.ReadOnly = true;
            this.variationName.Width = 190;
            // 
            // productBrand
            // 
            this.productBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productBrand.DataPropertyName = "BrandName";
            this.productBrand.HeaderText = "Brand";
            this.productBrand.Name = "productBrand";
            this.productBrand.ReadOnly = true;
            this.productBrand.Width = 80;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.DataPropertyName = "CategoryName";
            this.productCategory.HeaderText = "Category";
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            this.productCategory.Width = 191;
            // 
            // productSubCategory
            // 
            this.productSubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productSubCategory.DataPropertyName = "SubCategoryName";
            this.productSubCategory.HeaderText = "SubCategory";
            this.productSubCategory.Name = "productSubCategory";
            this.productSubCategory.ReadOnly = true;
            this.productSubCategory.Width = 190;
            // 
            // productStock
            // 
            this.productStock.DataPropertyName = "stock";
            this.productStock.HeaderText = "Stock";
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Width = 50;
            // 
            // productSalePrice
            // 
            this.productSalePrice.DataPropertyName = "sale_price";
            this.productSalePrice.HeaderText = "Sale Price";
            this.productSalePrice.Name = "productSalePrice";
            this.productSalePrice.ReadOnly = true;
            this.productSalePrice.Width = 70;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.TablePanelViewProducts);
            this.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewProducts";
            this.Size = new System.Drawing.Size(878, 408);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllProducts)).EndInit();
            this.TablePanelViewProducts.ResumeLayout(false);
            this.panelProductsGridView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TablePanelFilterControls.ResumeLayout(false);
            this.panelSearchByName.ResumeLayout(false);
            this.panelSearchByName.PerformLayout();
            this.panelSearchByBrand.ResumeLayout(false);
            this.panelSearchByBrand.PerformLayout();
            this.panelSortByColumn.ResumeLayout(false);
            this.panelSortByColumn.PerformLayout();
            this.panelResetFilters.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal KryptonDataGridView grdViewAllProducts;
        private TableLayoutPanel TablePanelViewProducts;
        private Panel panelProductsGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Label lblReportFilename;
        private TextBox txtReportFilename;
        private TableLayoutPanel tableLayoutPanel2;
        private KryptonButton btnGenerateReportAsExcel;
        private KryptonButton btnGenerateReportAsCSV;
        private GroupBox groupBox1;
        private TableLayoutPanel TablePanelFilterControls;
        private Panel panelSearchByName;
        private TextBox txtSearchProductByName;
        private Label lblSearchProductByName;
        private KryptonButton btnSearchProductByName;
        private Panel panelSearchByBrand;
        private Label lblSearchProductsByBrand;
        private TextBox txtSearchProductsByBrand;
        private KryptonButton btnSearchProductsByBrand;
        private Panel panelSortByColumn;
        private ComboBox ddlSortProducts;
        private ComboBox ddlSortOrder;
        private Label lblSortProducts;
        private Panel panelResetFilters;
        private KryptonButton btnResetSearch;
        private KryptonDataGridViewTextBoxColumn _variationId;
        private KryptonDataGridViewTextBoxColumn variationName;
        private KryptonDataGridViewTextBoxColumn productBrand;
        private KryptonDataGridViewTextBoxColumn productCategory;
        private KryptonDataGridViewTextBoxColumn productSubCategory;
        private KryptonDataGridViewTextBoxColumn productStock;
        private KryptonDataGridViewTextBoxColumn productSalePrice;
    }
}
