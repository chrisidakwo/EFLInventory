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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetSortCategories = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ddlSortCategoryName = new System.Windows.Forms.ComboBox();
            this.lblSortCategoryOrder = new System.Windows.Forms.Label();
            this.btnSearchCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSearchCategoryName = new System.Windows.Forms.Label();
            this.txtSearchCategoryName = new System.Windows.Forms.TextBox();
            this.groupAddUpdateCategory = new System.Windows.Forms.GroupBox();
            this.TablePanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.panelCategoriesGridView = new System.Windows.Forms.Panel();
            this.grdViewCategories = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.categoryId = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.categoryName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.TablePanelCategories.SuspendLayout();
            this.panelAddUpdateCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupAddUpdateCategory.SuspendLayout();
            this.TablePanelActionButtons.SuspendLayout();
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
            this.TablePanelCategories.Size = new System.Drawing.Size(715, 407);
            this.TablePanelCategories.TabIndex = 0;
            // 
            // panelAddUpdateCategory
            // 
            this.panelAddUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddUpdateCategory.Controls.Add(this.groupBox1);
            this.panelAddUpdateCategory.Controls.Add(this.groupAddUpdateCategory);
            this.panelAddUpdateCategory.Location = new System.Drawing.Point(6, 6);
            this.panelAddUpdateCategory.Name = "panelAddUpdateCategory";
            this.panelAddUpdateCategory.Size = new System.Drawing.Size(703, 153);
            this.panelAddUpdateCategory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnResetSortCategories);
            this.groupBox1.Controls.Add(this.ddlSortCategoryName);
            this.groupBox1.Controls.Add(this.lblSortCategoryOrder);
            this.groupBox1.Controls.Add(this.btnSearchCategoryName);
            this.groupBox1.Controls.Add(this.lblSearchCategoryName);
            this.groupBox1.Controls.Add(this.txtSearchCategoryName);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(397, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search/Sort Category";
            // 
            // btnResetSortCategories
            // 
            this.btnResetSortCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSortCategories.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnResetSortCategories.Location = new System.Drawing.Point(163, 86);
            this.btnResetSortCategories.Name = "btnResetSortCategories";
            this.btnResetSortCategories.Size = new System.Drawing.Size(100, 27);
            this.btnResetSortCategories.TabIndex = 5;
            this.btnResetSortCategories.Values.Text = "RESET";
            this.btnResetSortCategories.Click += new System.EventHandler(this.btnResetSortCategories_Click);
            // 
            // ddlSortCategoryName
            // 
            this.ddlSortCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ddlSortCategoryName.FormattingEnabled = true;
            this.ddlSortCategoryName.Location = new System.Drawing.Point(163, 55);
            this.ddlSortCategoryName.Name = "ddlSortCategoryName";
            this.ddlSortCategoryName.Size = new System.Drawing.Size(100, 24);
            this.ddlSortCategoryName.TabIndex = 4;
            this.ddlSortCategoryName.SelectedIndexChanged += new System.EventHandler(this.ddlSortCategoryName_SelectedIndexChanged);
            // 
            // lblSortCategoryOrder
            // 
            this.lblSortCategoryOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortCategoryOrder.AutoSize = true;
            this.lblSortCategoryOrder.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSortCategoryOrder.Location = new System.Drawing.Point(160, 34);
            this.lblSortCategoryOrder.Name = "lblSortCategoryOrder";
            this.lblSortCategoryOrder.Size = new System.Drawing.Size(54, 18);
            this.lblSortCategoryOrder.TabIndex = 3;
            this.lblSortCategoryOrder.Text = "Sort by:";
            // 
            // btnSearchCategoryName
            // 
            this.btnSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.btnSearchCategoryName.Location = new System.Drawing.Point(22, 85);
            this.btnSearchCategoryName.Name = "btnSearchCategoryName";
            this.btnSearchCategoryName.Size = new System.Drawing.Size(100, 28);
            this.btnSearchCategoryName.TabIndex = 2;
            this.btnSearchCategoryName.Values.Text = "SEARCH";
            this.btnSearchCategoryName.Click += new System.EventHandler(this.btnSearchCategoryName_Click);
            // 
            // lblSearchCategoryName
            // 
            this.lblSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchCategoryName.AutoSize = true;
            this.lblSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblSearchCategoryName.Location = new System.Drawing.Point(19, 35);
            this.lblSearchCategoryName.Name = "lblSearchCategoryName";
            this.lblSearchCategoryName.Size = new System.Drawing.Size(106, 18);
            this.lblSearchCategoryName.TabIndex = 1;
            this.lblSearchCategoryName.Text = "Search by name:";
            // 
            // txtSearchCategoryName
            // 
            this.txtSearchCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSearchCategoryName.Location = new System.Drawing.Point(22, 55);
            this.txtSearchCategoryName.Name = "txtSearchCategoryName";
            this.txtSearchCategoryName.Size = new System.Drawing.Size(100, 24);
            this.txtSearchCategoryName.TabIndex = 0;
            // 
            // groupAddUpdateCategory
            // 
            this.groupAddUpdateCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddUpdateCategory.Controls.Add(this.TablePanelActionButtons);
            this.groupAddUpdateCategory.Controls.Add(this.txtCategoryName);
            this.groupAddUpdateCategory.Controls.Add(this.lblCategoryName);
            this.groupAddUpdateCategory.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupAddUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.groupAddUpdateCategory.Location = new System.Drawing.Point(16, 17);
            this.groupAddUpdateCategory.Name = "groupAddUpdateCategory";
            this.groupAddUpdateCategory.Size = new System.Drawing.Size(363, 122);
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
            this.TablePanelActionButtons.Location = new System.Drawing.Point(31, 74);
            this.TablePanelActionButtons.Name = "TablePanelActionButtons";
            this.TablePanelActionButtons.RowCount = 1;
            this.TablePanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelActionButtons.Size = new System.Drawing.Size(303, 42);
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
            this.btnAddCategory.Size = new System.Drawing.Size(95, 36);
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
            this.btnUpdateCategory.Location = new System.Drawing.Point(104, 3);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(94, 36);
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
            this.btnDeleteCategory.Location = new System.Drawing.Point(204, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(96, 36);
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
            this.txtCategoryName.Location = new System.Drawing.Point(157, 35);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(174, 24);
            this.txtCategoryName.TabIndex = 4;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblCategoryName.Location = new System.Drawing.Point(27, 38);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(103, 18);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // panelCategoriesGridView
            // 
            this.panelCategoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCategoriesGridView.Controls.Add(this.grdViewCategories);
            this.panelCategoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategoriesGridView.Location = new System.Drawing.Point(6, 168);
            this.panelCategoriesGridView.Name = "panelCategoriesGridView";
            this.panelCategoriesGridView.Size = new System.Drawing.Size(703, 233);
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
            this.categoryName});
            this.grdViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewCategories.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewCategories.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewCategories.Location = new System.Drawing.Point(0, 0);
            this.grdViewCategories.MultiSelect = false;
            this.grdViewCategories.Name = "grdViewCategories";
            this.grdViewCategories.Size = new System.Drawing.Size(699, 229);
            this.grdViewCategories.TabIndex = 0;
            this.grdViewCategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewCategories_RowHeaderMouseClick);
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "id";
            this.categoryId.HeaderText = "Category ID";
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            this.categoryId.Width = 100;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.DataPropertyName = "name";
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Width = 558;
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
            this.Size = new System.Drawing.Size(715, 407);
            this.TablePanelCategories.ResumeLayout(false);
            this.panelAddUpdateCategory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAddUpdateCategory.ResumeLayout(false);
            this.groupAddUpdateCategory.PerformLayout();
            this.TablePanelActionButtons.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn categoryId;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.TableLayoutPanel TablePanelActionButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchCategoryName;
        private System.Windows.Forms.Label lblSearchCategoryName;
        private System.Windows.Forms.TextBox txtSearchCategoryName;
        private System.Windows.Forms.ComboBox ddlSortCategoryName;
        private System.Windows.Forms.Label lblSortCategoryOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResetSortCategories;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteCategory;
    }
}
