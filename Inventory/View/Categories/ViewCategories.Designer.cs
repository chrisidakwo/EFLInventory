namespace Inventory.View.Categories {
    partial class ViewCategories {
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
            this.TablePanelCategories = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddUpdateCategory = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupAddUpdateCategory = new System.Windows.Forms.GroupBox();
            this.TablePanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearchCategoryName = new System.Windows.Forms.TextBox();
            this.lblSearchCategoryName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlSortCategoryName = new System.Windows.Forms.ComboBox();
            this.btnResetSortCategories = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSortCategoryOrder = new System.Windows.Forms.Label();
            this.panelCategoriesGridView = new System.Windows.Forms.Panel();
            this.grdViewCategories = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.categoryId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.category_Name = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.subCategories = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.products = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.TablePanelCategories.SuspendLayout();
            this.panelAddUpdateCategory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupAddUpdateCategory.SuspendLayout();
            this.TablePanelActionButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCategoriesGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePanelCategories
            // 
            this.TablePanelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.TablePanelCategories.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TablePanelCategories.ColumnCount = 1;
            this.TablePanelCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelCategories.Controls.Add(this.panelAddUpdateCategory, 0, 0);
            this.TablePanelCategories.Controls.Add(this.panelCategoriesGridView, 0, 1);
            this.TablePanelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelCategories.Location = new System.Drawing.Point(0, 0);
            this.TablePanelCategories.Name = "TablePanelCategories";
            this.TablePanelCategories.RowCount = 2;
            this.TablePanelCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TablePanelCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanelCategories.Size = new System.Drawing.Size(878, 408);
            this.TablePanelCategories.TabIndex = 0;
            // 
            // panelAddUpdateCategory
            // 
            this.panelAddUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddUpdateCategory.Controls.Add(this.tableLayoutPanel1);
            this.panelAddUpdateCategory.Location = new System.Drawing.Point(6, 6);
            this.panelAddUpdateCategory.Name = "panelAddUpdateCategory";
            this.panelAddUpdateCategory.Size = new System.Drawing.Size(866, 153);
            this.panelAddUpdateCategory.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupAddUpdateCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 153);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupAddUpdateCategory
            // 
            this.groupAddUpdateCategory.Controls.Add(this.TablePanelActionButtons);
            this.groupAddUpdateCategory.Controls.Add(this.txtCategoryName);
            this.groupAddUpdateCategory.Controls.Add(this.lblCategoryName);
            this.groupAddUpdateCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAddUpdateCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupAddUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.groupAddUpdateCategory.Location = new System.Drawing.Point(3, 3);
            this.groupAddUpdateCategory.Name = "groupAddUpdateCategory";
            this.groupAddUpdateCategory.Size = new System.Drawing.Size(383, 147);
            this.groupAddUpdateCategory.TabIndex = 0;
            this.groupAddUpdateCategory.TabStop = false;
            this.groupAddUpdateCategory.Text = "Add/Update Category";
            // 
            // TablePanelActionButtons
            // 
            this.TablePanelActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanelActionButtons.ColumnCount = 3;
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33408F));
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33185F));
            this.TablePanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33408F));
            this.TablePanelActionButtons.Controls.Add(this.btnAddCategory, 0, 0);
            this.TablePanelActionButtons.Controls.Add(this.btnUpdateCategory, 1, 0);
            this.TablePanelActionButtons.Controls.Add(this.btnDeleteCategory, 2, 0);
            this.TablePanelActionButtons.Location = new System.Drawing.Point(30, 87);
            this.TablePanelActionButtons.Name = "TablePanelActionButtons";
            this.TablePanelActionButtons.RowCount = 1;
            this.TablePanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelActionButtons.Size = new System.Drawing.Size(315, 42);
            this.TablePanelActionButtons.TabIndex = 5;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnAddCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(99, 36);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Values.Text = "INSERT";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnUpdateCategory.Location = new System.Drawing.Point(108, 3);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(98, 36);
            this.btnUpdateCategory.TabIndex = 2;
            this.btnUpdateCategory.Values.Text = "UPDATE";
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnDeleteCategory.Location = new System.Drawing.Point(212, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(100, 36);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Values.Text = "DELETE";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtCategoryName.Location = new System.Drawing.Point(159, 49);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(186, 24);
            this.txtCategoryName.TabIndex = 4;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblCategoryName.Location = new System.Drawing.Point(27, 52);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(103, 18);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(392, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search/Sort Category";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.1845F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8155F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 124);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchCategoryName);
            this.panel1.Controls.Add(this.txtSearchCategoryName);
            this.panel1.Controls.Add(this.lblSearchCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 118);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchCategoryName
            // 
            this.btnSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnSearchCategoryName.Location = new System.Drawing.Point(5, 68);
            this.btnSearchCategoryName.Name = "btnSearchCategoryName";
            this.btnSearchCategoryName.Size = new System.Drawing.Size(120, 36);
            this.btnSearchCategoryName.TabIndex = 2;
            this.btnSearchCategoryName.Values.Text = "SEARCH";
            this.btnSearchCategoryName.Click += new System.EventHandler(this.btnSearchCategoryName_Click);
            // 
            // txtSearchCategoryName
            // 
            this.txtSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSearchCategoryName.Location = new System.Drawing.Point(5, 35);
            this.txtSearchCategoryName.Name = "txtSearchCategoryName";
            this.txtSearchCategoryName.Size = new System.Drawing.Size(105, 24);
            this.txtSearchCategoryName.TabIndex = 0;
            // 
            // lblSearchCategoryName
            // 
            this.lblSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchCategoryName.AutoSize = true;
            this.lblSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSearchCategoryName.Location = new System.Drawing.Point(3, 14);
            this.lblSearchCategoryName.Name = "lblSearchCategoryName";
            this.lblSearchCategoryName.Size = new System.Drawing.Size(106, 18);
            this.lblSearchCategoryName.TabIndex = 1;
            this.lblSearchCategoryName.Text = "Search by name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddlSortCategoryName);
            this.panel2.Controls.Add(this.btnResetSortCategories);
            this.panel2.Controls.Add(this.lblSortCategoryOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(126, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 118);
            this.panel2.TabIndex = 1;
            // 
            // ddlSortCategoryName
            // 
            this.ddlSortCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlSortCategoryName.FormattingEnabled = true;
            this.ddlSortCategoryName.Location = new System.Drawing.Point(6, 35);
            this.ddlSortCategoryName.Name = "ddlSortCategoryName";
            this.ddlSortCategoryName.Size = new System.Drawing.Size(106, 24);
            this.ddlSortCategoryName.TabIndex = 4;
            this.ddlSortCategoryName.SelectedIndexChanged += new System.EventHandler(this.ddlSortCategoryName_SelectedIndexChanged);
            // 
            // btnResetSortCategories
            // 
            this.btnResetSortCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSortCategories.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnResetSortCategories.Location = new System.Drawing.Point(6, 68);
            this.btnResetSortCategories.Name = "btnResetSortCategories";
            this.btnResetSortCategories.Size = new System.Drawing.Size(120, 36);
            this.btnResetSortCategories.TabIndex = 5;
            this.btnResetSortCategories.Values.Text = "RESET";
            this.btnResetSortCategories.Click += new System.EventHandler(this.btnResetSortCategories_Click);
            // 
            // lblSortCategoryOrder
            // 
            this.lblSortCategoryOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortCategoryOrder.AutoSize = true;
            this.lblSortCategoryOrder.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSortCategoryOrder.Location = new System.Drawing.Point(9, 14);
            this.lblSortCategoryOrder.Name = "lblSortCategoryOrder";
            this.lblSortCategoryOrder.Size = new System.Drawing.Size(54, 18);
            this.lblSortCategoryOrder.TabIndex = 3;
            this.lblSortCategoryOrder.Text = "Sort by:";
            // 
            // panelCategoriesGridView
            // 
            this.panelCategoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCategoriesGridView.Controls.Add(this.grdViewCategories);
            this.panelCategoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategoriesGridView.Location = new System.Drawing.Point(6, 168);
            this.panelCategoriesGridView.Name = "panelCategoriesGridView";
            this.panelCategoriesGridView.Size = new System.Drawing.Size(866, 234);
            this.panelCategoriesGridView.TabIndex = 1;
            // 
            // grdViewCategories
            // 
            this.grdViewCategories.AllowUserToAddRows = false;
            this.grdViewCategories.AllowUserToDeleteRows = false;
            this.grdViewCategories.AllowUserToResizeColumns = false;
            this.grdViewCategories.AllowUserToResizeRows = false;
            this.grdViewCategories.ColumnHeadersHeight = 40;
            this.grdViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.category_Name,
            this.subCategories,
            this.products});
            this.grdViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewCategories.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewCategories.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.Location = new System.Drawing.Point(0, 0);
            this.grdViewCategories.MultiSelect = false;
            this.grdViewCategories.Name = "grdViewCategories";
            this.grdViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewCategories.Size = new System.Drawing.Size(862, 230);
            this.grdViewCategories.TabIndex = 0;
            this.grdViewCategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewCategories_RowHeaderMouseClick);
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "id";
            this.categoryId.HeaderText = "Category ID";
            this.categoryId.Name = "categoryId";
            this.categoryId.Width = 100;
            // 
            // category_Name
            // 
            this.category_Name.DataPropertyName = "name";
            this.category_Name.HeaderText = "Category Name";
            this.category_Name.Name = "category_Name";
            this.category_Name.ReadOnly = true;
            this.category_Name.Width = 200;
            // 
            // subCategories
            // 
            this.subCategories.DataPropertyName = "subCategories";
            this.subCategories.HeaderText = "SubCategories";
            this.subCategories.Name = "subCategories";
            this.subCategories.ReadOnly = true;
            this.subCategories.Width = 200;
            // 
            // products
            // 
            this.products.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.products.DataPropertyName = "products";
            this.products.HeaderText = "Products";
            this.products.Name = "products";
            this.products.ReadOnly = true;
            this.products.Width = 321;
            // 
            // ViewCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.TablePanelCategories);
            this.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewCategories";
            this.Size = new System.Drawing.Size(878, 408);
            this.TablePanelCategories.ResumeLayout(false);
            this.panelAddUpdateCategory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupAddUpdateCategory.ResumeLayout(false);
            this.groupAddUpdateCategory.PerformLayout();
            this.TablePanelActionButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCategoriesGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelCategories;
        private System.Windows.Forms.Panel panelAddUpdateCategory;
        private System.Windows.Forms.Panel panelCategoriesGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdViewCategories;
        private System.Windows.Forms.GroupBox groupAddUpdateCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TableLayoutPanel TablePanelActionButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchCategoryName;
        private System.Windows.Forms.Label lblSearchCategoryName;
        private System.Windows.Forms.TextBox txtSearchCategoryName;
        private System.Windows.Forms.ComboBox ddlSortCategoryName;
        private System.Windows.Forms.Label lblSortCategoryOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResetSortCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn categoryId;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn category_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn subCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn products;
    }
}
