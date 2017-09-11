namespace Inventory.View.Dealers {
    partial class ViewDealers {
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
            this.TablePanelViewDealers = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddUpdateDealer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupSortDealers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchDealer = new System.Windows.Forms.TextBox();
            this.lblSortDealerByName = new System.Windows.Forms.Label();
            this.btnSearchDealerByName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlSortBy = new System.Windows.Forms.ComboBox();
            this.btnResetSort = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblSortDealers = new System.Windows.Forms.Label();
            this.ddlSortOrder = new System.Windows.Forms.ComboBox();
            this.groupAddUpdateDealer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDealerPhone = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblDealerPhone = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDealerAddress = new System.Windows.Forms.TextBox();
            this.txtDealerEmail = new System.Windows.Forms.TextBox();
            this.lblDealerEmail = new System.Windows.Forms.Label();
            this.lblDealerAddress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDealer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateDealer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelViewAllDealers = new System.Windows.Forms.Panel();
            this.grdViewAllDealers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dealerID = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dealersName = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dealerPhone = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dealerEmail = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dealerProducts = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.TablePanelViewDealers.SuspendLayout();
            this.panelAddUpdateDealer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupSortDealers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupAddUpdateDealer.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelViewAllDealers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllDealers)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePanelViewDealers
            // 
            this.TablePanelViewDealers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TablePanelViewDealers.ColumnCount = 1;
            this.TablePanelViewDealers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelViewDealers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanelViewDealers.Controls.Add(this.panelAddUpdateDealer, 0, 0);
            this.TablePanelViewDealers.Controls.Add(this.panelViewAllDealers, 0, 1);
            this.TablePanelViewDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelViewDealers.Location = new System.Drawing.Point(0, 0);
            this.TablePanelViewDealers.Name = "TablePanelViewDealers";
            this.TablePanelViewDealers.RowCount = 2;
            this.TablePanelViewDealers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TablePanelViewDealers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanelViewDealers.Size = new System.Drawing.Size(715, 407);
            this.TablePanelViewDealers.TabIndex = 0;
            // 
            // panelAddUpdateDealer
            // 
            this.panelAddUpdateDealer.Controls.Add(this.tableLayoutPanel3);
            this.panelAddUpdateDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUpdateDealer.Location = new System.Drawing.Point(6, 6);
            this.panelAddUpdateDealer.Name = "panelAddUpdateDealer";
            this.panelAddUpdateDealer.Size = new System.Drawing.Size(703, 153);
            this.panelAddUpdateDealer.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.73969F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.26031F));
            this.tableLayoutPanel3.Controls.Add(this.groupSortDealers, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupAddUpdateDealer, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 153);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupSortDealers
            // 
            this.groupSortDealers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSortDealers.Controls.Add(this.tableLayoutPanel2);
            this.groupSortDealers.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupSortDealers.ForeColor = System.Drawing.Color.White;
            this.groupSortDealers.Location = new System.Drawing.Point(430, 3);
            this.groupSortDealers.Name = "groupSortDealers";
            this.groupSortDealers.Size = new System.Drawing.Size(270, 147);
            this.groupSortDealers.TabIndex = 1;
            this.groupSortDealers.TabStop = false;
            this.groupSortDealers.Text = "Search/Sort Dealers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 124);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchDealer);
            this.panel1.Controls.Add(this.lblSortDealerByName);
            this.panel1.Controls.Add(this.btnSearchDealerByName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 118);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchDealer
            // 
            this.txtSearchDealer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDealer.Location = new System.Drawing.Point(3, 50);
            this.txtSearchDealer.Name = "txtSearchDealer";
            this.txtSearchDealer.Size = new System.Drawing.Size(111, 24);
            this.txtSearchDealer.TabIndex = 3;
            // 
            // lblSortDealerByName
            // 
            this.lblSortDealerByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortDealerByName.AutoSize = true;
            this.lblSortDealerByName.Location = new System.Drawing.Point(3, 29);
            this.lblSortDealerByName.Name = "lblSortDealerByName";
            this.lblSortDealerByName.Size = new System.Drawing.Size(51, 18);
            this.lblSortDealerByName.TabIndex = 0;
            this.lblSortDealerByName.Text = "Search:";
            // 
            // btnSearchDealerByName
            // 
            this.btnSearchDealerByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDealerByName.Location = new System.Drawing.Point(3, 80);
            this.btnSearchDealerByName.Name = "btnSearchDealerByName";
            this.btnSearchDealerByName.Size = new System.Drawing.Size(111, 32);
            this.btnSearchDealerByName.TabIndex = 2;
            this.btnSearchDealerByName.Text = "SEARCH";
            this.btnSearchDealerByName.Click += new System.EventHandler(this.btnSearchDealerByName_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddlSortBy);
            this.panel2.Controls.Add(this.btnResetSort);
            this.panel2.Controls.Add(this.lblSortDealers);
            this.panel2.Controls.Add(this.ddlSortOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(135, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 118);
            this.panel2.TabIndex = 1;
            // 
            // ddlSortBy
            // 
            this.ddlSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortBy.FormattingEnabled = true;
            this.ddlSortBy.Location = new System.Drawing.Point(12, 19);
            this.ddlSortBy.Name = "ddlSortBy";
            this.ddlSortBy.Size = new System.Drawing.Size(110, 24);
            this.ddlSortBy.TabIndex = 4;
            this.ddlSortBy.SelectedIndexChanged += new System.EventHandler(this.ddlSortBy_SelectedIndexChanged);
            // 
            // btnResetSort
            // 
            this.btnResetSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSort.Location = new System.Drawing.Point(12, 80);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(110, 32);
            this.btnResetSort.TabIndex = 6;
            this.btnResetSort.Text = "RESET";
            this.btnResetSort.Click += new System.EventHandler(this.btnResetSort_Click);
            // 
            // lblSortDealers
            // 
            this.lblSortDealers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortDealers.AutoSize = true;
            this.lblSortDealers.Location = new System.Drawing.Point(9, -2);
            this.lblSortDealers.Name = "lblSortDealers";
            this.lblSortDealers.Size = new System.Drawing.Size(54, 18);
            this.lblSortDealers.TabIndex = 1;
            this.lblSortDealers.Text = "Sort by:";
            // 
            // ddlSortOrder
            // 
            this.ddlSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSortOrder.FormattingEnabled = true;
            this.ddlSortOrder.Location = new System.Drawing.Point(12, 49);
            this.ddlSortOrder.Name = "ddlSortOrder";
            this.ddlSortOrder.Size = new System.Drawing.Size(110, 24);
            this.ddlSortOrder.TabIndex = 5;
            this.ddlSortOrder.SelectedIndexChanged += new System.EventHandler(this.ddlSortOrder_SelectedIndexChanged);
            // 
            // groupAddUpdateDealer
            // 
            this.groupAddUpdateDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddUpdateDealer.Controls.Add(this.tableLayoutPanel4);
            this.groupAddUpdateDealer.Controls.Add(this.tableLayoutPanel1);
            this.groupAddUpdateDealer.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.groupAddUpdateDealer.ForeColor = System.Drawing.Color.White;
            this.groupAddUpdateDealer.Location = new System.Drawing.Point(3, 3);
            this.groupAddUpdateDealer.Name = "groupAddUpdateDealer";
            this.groupAddUpdateDealer.Size = new System.Drawing.Size(421, 147);
            this.groupAddUpdateDealer.TabIndex = 0;
            this.groupAddUpdateDealer.TabStop = false;
            this.groupAddUpdateDealer.Text = "Add/Update Dealer";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.65526F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.34474F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(409, 78);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDealerPhone);
            this.panel3.Controls.Add(this.txtDealerName);
            this.panel3.Controls.Add(this.lblDealerName);
            this.panel3.Controls.Add(this.lblDealerPhone);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 72);
            this.panel3.TabIndex = 0;
            // 
            // txtDealerPhone
            // 
            this.txtDealerPhone.Location = new System.Drawing.Point(60, 40);
            this.txtDealerPhone.Name = "txtDealerPhone";
            this.txtDealerPhone.Size = new System.Drawing.Size(123, 24);
            this.txtDealerPhone.TabIndex = 3;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDealerName.Location = new System.Drawing.Point(59, 6);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(124, 24);
            this.txtDealerName.TabIndex = 1;
            // 
            // lblDealerName
            // 
            this.lblDealerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblDealerName.Location = new System.Drawing.Point(7, 9);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(46, 18);
            this.lblDealerName.TabIndex = 0;
            this.lblDealerName.Text = "Name:";
            // 
            // lblDealerPhone
            // 
            this.lblDealerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDealerPhone.AutoSize = true;
            this.lblDealerPhone.Location = new System.Drawing.Point(3, 43);
            this.lblDealerPhone.Name = "lblDealerPhone";
            this.lblDealerPhone.Size = new System.Drawing.Size(50, 18);
            this.lblDealerPhone.TabIndex = 2;
            this.lblDealerPhone.Text = "Phone:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDealerAddress);
            this.panel4.Controls.Add(this.txtDealerEmail);
            this.panel4.Controls.Add(this.lblDealerEmail);
            this.panel4.Controls.Add(this.lblDealerAddress);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(202, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 72);
            this.panel4.TabIndex = 1;
            // 
            // txtDealerAddress
            // 
            this.txtDealerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDealerAddress.Location = new System.Drawing.Point(66, 41);
            this.txtDealerAddress.Name = "txtDealerAddress";
            this.txtDealerAddress.Size = new System.Drawing.Size(124, 24);
            this.txtDealerAddress.TabIndex = 9;
            // 
            // txtDealerEmail
            // 
            this.txtDealerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDealerEmail.Location = new System.Drawing.Point(66, 9);
            this.txtDealerEmail.Name = "txtDealerEmail";
            this.txtDealerEmail.Size = new System.Drawing.Size(124, 24);
            this.txtDealerEmail.TabIndex = 6;
            // 
            // lblDealerEmail
            // 
            this.lblDealerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDealerEmail.AutoSize = true;
            this.lblDealerEmail.Location = new System.Drawing.Point(16, 12);
            this.lblDealerEmail.Name = "lblDealerEmail";
            this.lblDealerEmail.Size = new System.Drawing.Size(44, 18);
            this.lblDealerEmail.TabIndex = 5;
            this.lblDealerEmail.Text = "Email:";
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDealerAddress.AutoSize = true;
            this.lblDealerAddress.Location = new System.Drawing.Point(1, 46);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(59, 18);
            this.lblDealerAddress.TabIndex = 8;
            this.lblDealerAddress.Text = "Address:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.78728F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddDealer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateDealer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 38);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnAddDealer
            // 
            this.btnAddDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDealer.Location = new System.Drawing.Point(3, 3);
            this.btnAddDealer.Name = "btnAddDealer";
            this.btnAddDealer.Size = new System.Drawing.Size(110, 32);
            this.btnAddDealer.TabIndex = 0;
            this.btnAddDealer.Text = "SAVE";
            this.btnAddDealer.Click += new System.EventHandler(this.btnAddDealer_Click);
            // 
            // btnUpdateDealer
            // 
            this.btnUpdateDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDealer.Location = new System.Drawing.Point(119, 3);
            this.btnUpdateDealer.Name = "btnUpdateDealer";
            this.btnUpdateDealer.Size = new System.Drawing.Size(107, 32);
            this.btnUpdateDealer.TabIndex = 1;
            this.btnUpdateDealer.Text = "UPDATE";
            this.btnUpdateDealer.Click += new System.EventHandler(this.btnUpdateDealer_Click);
            // 
            // panelViewAllDealers
            // 
            this.panelViewAllDealers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelViewAllDealers.Controls.Add(this.grdViewAllDealers);
            this.panelViewAllDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAllDealers.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.panelViewAllDealers.Location = new System.Drawing.Point(6, 168);
            this.panelViewAllDealers.Name = "panelViewAllDealers";
            this.panelViewAllDealers.Size = new System.Drawing.Size(703, 233);
            this.panelViewAllDealers.TabIndex = 1;
            // 
            // grdViewAllDealers
            // 
            this.grdViewAllDealers.AllowUserToAddRows = false;
            this.grdViewAllDealers.AllowUserToDeleteRows = false;
            this.grdViewAllDealers.ColumnHeadersHeight = 40;
            this.grdViewAllDealers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealerID,
            this.dealersName,
            this.dealerPhone,
            this.dealerEmail,
            this.dealerProducts});
            this.grdViewAllDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewAllDealers.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.grdViewAllDealers.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.grdViewAllDealers.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllDealers.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllDealers.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.grdViewAllDealers.Location = new System.Drawing.Point(0, 0);
            this.grdViewAllDealers.Name = "grdViewAllDealers";
            this.grdViewAllDealers.ReadOnly = true;
            this.grdViewAllDealers.Size = new System.Drawing.Size(699, 229);
            this.grdViewAllDealers.TabIndex = 0;
            this.grdViewAllDealers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewAllDealers_RowHeaderMouseClick);
            // 
            // dealerID
            // 
            this.dealerID.DataPropertyName = "id";
            this.dealerID.HeaderText = "Dealer ID";
            this.dealerID.Name = "dealerID";
            this.dealerID.ReadOnly = true;
            this.dealerID.Width = 100;
            // 
            // dealersName
            // 
            this.dealersName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dealersName.DataPropertyName = "name";
            this.dealersName.HeaderText = "Dealer Name";
            this.dealersName.Name = "dealersName";
            this.dealersName.ReadOnly = true;
            this.dealersName.Width = 179;
            // 
            // dealerPhone
            // 
            this.dealerPhone.DataPropertyName = "phone";
            this.dealerPhone.HeaderText = "Phone Number";
            this.dealerPhone.Name = "dealerPhone";
            this.dealerPhone.ReadOnly = true;
            this.dealerPhone.Width = 100;
            // 
            // dealerEmail
            // 
            this.dealerEmail.DataPropertyName = "email";
            this.dealerEmail.HeaderText = "Email Address";
            this.dealerEmail.Name = "dealerEmail";
            this.dealerEmail.ReadOnly = true;
            this.dealerEmail.Width = 100;
            // 
            // dealerProducts
            // 
            this.dealerProducts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dealerProducts.DataPropertyName = "products";
            this.dealerProducts.HeaderText = "Products";
            this.dealerProducts.Name = "dealerProducts";
            this.dealerProducts.ReadOnly = true;
            this.dealerProducts.Width = 179;
            // 
            // ViewDealers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.TablePanelViewDealers);
            this.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewDealers";
            this.Size = new System.Drawing.Size(715, 407);
            this.TablePanelViewDealers.ResumeLayout(false);
            this.panelAddUpdateDealer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupSortDealers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupAddUpdateDealer.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelViewAllDealers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewAllDealers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelViewDealers;
        private System.Windows.Forms.Panel panelAddUpdateDealer;
        private System.Windows.Forms.GroupBox groupAddUpdateDealer;
        private System.Windows.Forms.GroupBox groupSortDealers;
        private System.Windows.Forms.Panel panelViewAllDealers;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdViewAllDealers;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label lblDealerPhone;
        private System.Windows.Forms.TextBox txtDealerEmail;
        private System.Windows.Forms.Label lblDealerEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddDealer;
        private System.Windows.Forms.Label lblDealerAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateDealer;
        private System.Windows.Forms.Label lblSortDealers;
        private System.Windows.Forms.ComboBox ddlSortBy;
        private System.Windows.Forms.ComboBox ddlSortOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnResetSort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSortDealerByName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchDealerByName;
        private System.Windows.Forms.TextBox txtSearchDealer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDealerAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dealerID;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dealersName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dealerPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dealerEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn dealerProducts;
        private System.Windows.Forms.TextBox txtDealerPhone;
    }
}
