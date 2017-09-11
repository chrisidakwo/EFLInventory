namespace Inventory.View.SubCategories {
    partial class ViewSubCategories {
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
            this.TablePanelSubCategories = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddUpdateSubCategories = new System.Windows.Forms.Panel();
            this.panelSubCategoriesGridView = new System.Windows.Forms.Panel();
            this.grdViewSubCategories = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.subCategoryId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.subCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.categoryName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnResetSubCategories = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.ddlSortBy = new System.Windows.Forms.ComboBox();
            this.ddlSortOrder = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchSubCategories = new System.Windows.Forms.TextBox();
            this.btnSearchSubCategories = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSearchSubCategories = new System.Windows.Forms.Label();
            this.groupAddUpdateSubCategory = new System.Windows.Forms.GroupBox();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.txtSubCategoryName = new System.Windows.Forms.TextBox();
            this.TablePanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteSubCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateSubCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddSubCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ddlCategories = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TablePanelSubCategories.SuspendLayout();
            this.panelAddUpdateSubCategories.SuspendLayout();
            this.panelSubCategoriesGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSubCategories)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupAddUpdateSubCategory.SuspendLayout();
            this.TablePanelActionButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanelSubCategories
            // 
            this.TablePanelSubCategories.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TablePanelSubCategories.ColumnCount = 1;
            this.TablePanelSubCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelSubCategories.Controls.Add(this.panelAddUpdateSubCategories, 0, 0);
            this.TablePanelSubCategories.Controls.Add(this.panelSubCategoriesGridView, 0, 1);
            this.TablePanelSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelSubCategories.Location = new System.Drawing.Point(0, 0);
            this.TablePanelSubCategories.Name = "TablePanelSubCategories";
            this.TablePanelSubCategories.RowCount = 2;
            this.TablePanelSubCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TablePanelSubCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanelSubCategories.Size = new System.Drawing.Size(715, 407);
            this.TablePanelSubCategories.TabIndex = 0;
            // 
            // panelAddUpdateSubCategories
            // 
            this.panelAddUpdateSubCategories.Controls.Add(this.tableLayoutPanel2);
            this.panelAddUpdateSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUpdateSubCategories.ForeColor = System.Drawing.Color.White;
            this.panelAddUpdateSubCategories.Location = new System.Drawing.Point(6, 6);
            this.panelAddUpdateSubCategories.Name = "panelAddUpdateSubCategories";
            this.panelAddUpdateSubCategories.Size = new System.Drawing.Size(703, 153);
            this.panelAddUpdateSubCategories.TabIndex = 0;
            // 
            // panelSubCategoriesGridView
            // 
            this.panelSubCategoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSubCategoriesGridView.Controls.Add(this.grdViewSubCategories);
            this.panelSubCategoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubCategoriesGridView.Location = new System.Drawing.Point(6, 168);
            this.panelSubCategoriesGridView.Name = "panelSubCategoriesGridView";
            this.panelSubCategoriesGridView.Size = new System.Drawing.Size(703, 233);
            this.panelSubCategoriesGridView.TabIndex = 1;
            // 
            // grdViewSubCategories
            // 
            this.grdViewSubCategories.AllowUserToAddRows = false;
            this.grdViewSubCategories.AllowUserToDeleteRows = false;
            this.grdViewSubCategories.ColumnHeadersHeight = 40;
            this.grdViewSubCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCategoryId,
            this.subCategoryName,
            this.categoryName});
            this.grdViewSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewSubCategories.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewSubCategories.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewSubCategories.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSubCategories.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSubCategories.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewSubCategories.Location = new System.Drawing.Point(0, 0);
            this.grdViewSubCategories.MultiSelect = false;
            this.grdViewSubCategories.Name = "grdViewSubCategories";
            this.grdViewSubCategories.ReadOnly = true;
            this.grdViewSubCategories.Size = new System.Drawing.Size(699, 229);
            this.grdViewSubCategories.TabIndex = 0;
            this.grdViewSubCategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewSubCategories_RowHeaderMouseClick);
            // 
            // subCategoryId
            // 
            this.subCategoryId.DataPropertyName = "id";
            this.subCategoryId.HeaderText = "SubCategory ID";
            this.subCategoryId.Name = "subCategoryId";
            this.subCategoryId.ReadOnly = true;
            this.subCategoryId.Width = 100;
            // 
            // subCategoryName
            // 
            this.subCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subCategoryName.DataPropertyName = "name";
            this.subCategoryName.HeaderText = "SubCategory Name";
            this.subCategoryName.Name = "subCategoryName";
            this.subCategoryName.ReadOnly = true;
            this.subCategoryName.Width = 279;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.DataPropertyName = "category_name";
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 279;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(316, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search/Sort SubCategories";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 124);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnResetSubCategories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 118);
            this.panel3.TabIndex = 2;
            // 
            // btnResetSubCategories
            // 
            this.btnResetSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSubCategories.Location = new System.Drawing.Point(7, 70);
            this.btnResetSubCategories.Name = "btnResetSubCategories";
            this.btnResetSubCategories.Size = new System.Drawing.Size(115, 32);
            this.btnResetSubCategories.TabIndex = 0;
            this.btnResetSubCategories.Text = "RESET";
            this.btnResetSubCategories.Click += new System.EventHandler(this.btnResetSubCategories_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddlSortOrder);
            this.panel2.Controls.Add(this.ddlSortBy);
            this.panel2.Controls.Add(this.lblSortBy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(128, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 118);
            this.panel2.TabIndex = 1;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(-1, 27);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(54, 18);
            this.lblSortBy.TabIndex = 0;
            this.lblSortBy.Text = "Sort by:";
            // 
            // ddlSortBy
            // 
            this.ddlSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortBy.FormattingEnabled = true;
            this.ddlSortBy.Location = new System.Drawing.Point(2, 48);
            this.ddlSortBy.Name = "ddlSortBy";
            this.ddlSortBy.Size = new System.Drawing.Size(108, 24);
            this.ddlSortBy.TabIndex = 1;
            this.ddlSortBy.SelectedIndexChanged += new System.EventHandler(this.ddlSortBy_SelectedIndexChanged);
            // 
            // ddlSortOrder
            // 
            this.ddlSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortOrder.FormattingEnabled = true;
            this.ddlSortOrder.Location = new System.Drawing.Point(2, 78);
            this.ddlSortOrder.Name = "ddlSortOrder";
            this.ddlSortOrder.Size = new System.Drawing.Size(109, 24);
            this.ddlSortOrder.TabIndex = 2;
            this.ddlSortOrder.SelectedIndexChanged += new System.EventHandler(this.ddlSortOrder_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchSubCategories);
            this.panel1.Controls.Add(this.btnSearchSubCategories);
            this.panel1.Controls.Add(this.txtSearchSubCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 118);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchSubCategories
            // 
            this.txtSearchSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSubCategories.Location = new System.Drawing.Point(0, 40);
            this.txtSearchSubCategories.Name = "txtSearchSubCategories";
            this.txtSearchSubCategories.Size = new System.Drawing.Size(109, 24);
            this.txtSearchSubCategories.TabIndex = 1;
            // 
            // btnSearchSubCategories
            // 
            this.btnSearchSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSubCategories.Location = new System.Drawing.Point(0, 70);
            this.btnSearchSubCategories.Name = "btnSearchSubCategories";
            this.btnSearchSubCategories.Size = new System.Drawing.Size(109, 32);
            this.btnSearchSubCategories.TabIndex = 2;
            this.btnSearchSubCategories.Text = "SEARCH";
            this.btnSearchSubCategories.Click += new System.EventHandler(this.btnSearchSubCategories_Click);
            // 
            // lblSearchSubCategories
            // 
            this.lblSearchSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSubCategories.AutoSize = true;
            this.lblSearchSubCategories.Location = new System.Drawing.Point(-3, 19);
            this.lblSearchSubCategories.Name = "lblSearchSubCategories";
            this.lblSearchSubCategories.Size = new System.Drawing.Size(51, 18);
            this.lblSearchSubCategories.TabIndex = 0;
            this.lblSearchSubCategories.Text = "Search:";
            // 
            // groupAddUpdateSubCategory
            // 
            this.groupAddUpdateSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddUpdateSubCategory.Controls.Add(this.ddlCategories);
            this.groupAddUpdateSubCategory.Controls.Add(this.lblCategory);
            this.groupAddUpdateSubCategory.Controls.Add(this.TablePanelActionButtons);
            this.groupAddUpdateSubCategory.Controls.Add(this.txtSubCategoryName);
            this.groupAddUpdateSubCategory.Controls.Add(this.lblSubCategoryName);
            this.groupAddUpdateSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupAddUpdateSubCategory.ForeColor = System.Drawing.Color.White;
            this.groupAddUpdateSubCategory.Location = new System.Drawing.Point(3, 3);
            this.groupAddUpdateSubCategory.Name = "groupAddUpdateSubCategory";
            this.groupAddUpdateSubCategory.Size = new System.Drawing.Size(307, 147);
            this.groupAddUpdateSubCategory.TabIndex = 0;
            this.groupAddUpdateSubCategory.TabStop = false;
            this.groupAddUpdateSubCategory.Text = "Add/Update SubCategory";
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategoryName.AutoSize = true;
            this.lblSubCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSubCategoryName.Location = new System.Drawing.Point(45, 33);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(46, 18);
            this.lblSubCategoryName.TabIndex = 0;
            this.lblSubCategoryName.Text = "Name:";
            // 
            // txtSubCategoryName
            // 
            this.txtSubCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSubCategoryName.Location = new System.Drawing.Point(104, 30);
            this.txtSubCategoryName.Name = "txtSubCategoryName";
            this.txtSubCategoryName.Size = new System.Drawing.Size(174, 24);
            this.txtSubCategoryName.TabIndex = 1;
            // 
            // TablePanelActionButtons
            // 
            this.TablePanelActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelActionButtons.ColumnCount = 3;
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelActionButtons.Controls.Add(this.btnAddSubCategory, 0, 0);
            this.TablePanelActionButtons.Controls.Add(this.btnUpdateSubCategory, 1, 0);
            this.TablePanelActionButtons.Controls.Add(this.btnDeleteSubCategory, 2, 0);
            this.TablePanelActionButtons.Location = new System.Drawing.Point(26, 93);
            this.TablePanelActionButtons.Name = "TablePanelActionButtons";
            this.TablePanelActionButtons.RowCount = 1;
            this.TablePanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TablePanelActionButtons.Size = new System.Drawing.Size(255, 38);
            this.TablePanelActionButtons.TabIndex = 2;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(173, 3);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(79, 32);
            this.btnDeleteSubCategory.TabIndex = 2;
            this.btnDeleteSubCategory.Text = "DELETE";
            this.btnDeleteSubCategory.Click += new System.EventHandler(this.btnDeleteSubCategory_Click);
            // 
            // btnUpdateSubCategory
            // 
            this.btnUpdateSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnUpdateSubCategory.Location = new System.Drawing.Point(88, 3);
            this.btnUpdateSubCategory.Name = "btnUpdateSubCategory";
            this.btnUpdateSubCategory.Size = new System.Drawing.Size(79, 32);
            this.btnUpdateSubCategory.TabIndex = 1;
            this.btnUpdateSubCategory.Text = "UPDATE";
            this.btnUpdateSubCategory.Click += new System.EventHandler(this.btnUpdateSubCategory_Click);
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnAddSubCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(79, 32);
            this.btnAddSubCategory.TabIndex = 0;
            this.btnAddSubCategory.Text = "INSERT";
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblCategory.Location = new System.Drawing.Point(26, 63);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // ddlCategories
            // 
            this.ddlCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCategories.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlCategories.FormattingEnabled = true;
            this.ddlCategories.Location = new System.Drawing.Point(104, 60);
            this.ddlCategories.Name = "ddlCategories";
            this.ddlCategories.Size = new System.Drawing.Size(174, 24);
            this.ddlCategories.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.52347F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.47653F));
            this.tableLayoutPanel2.Controls.Add(this.groupAddUpdateSubCategory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 153);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ViewSubCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.TablePanelSubCategories);
            this.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(715, 407);
            this.Name = "ViewSubCategories";
            this.Size = new System.Drawing.Size(715, 407);
            this.TablePanelSubCategories.ResumeLayout(false);
            this.panelAddUpdateSubCategories.ResumeLayout(false);
            this.panelSubCategoriesGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSubCategories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupAddUpdateSubCategory.ResumeLayout(false);
            this.groupAddUpdateSubCategory.PerformLayout();
            this.TablePanelActionButtons.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelSubCategories;
        private System.Windows.Forms.Panel panelAddUpdateSubCategories;
        private System.Windows.Forms.Panel panelSubCategoriesGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdViewSubCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn subCategoryId;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn subCategoryName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupAddUpdateSubCategory;
        private System.Windows.Forms.ComboBox ddlCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel TablePanelActionButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddSubCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateSubCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteSubCategory;
        private System.Windows.Forms.TextBox txtSubCategoryName;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchSubCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchSubCategories;
        private System.Windows.Forms.TextBox txtSearchSubCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ddlSortOrder;
        private System.Windows.Forms.ComboBox ddlSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResetSubCategories;
    }
}
