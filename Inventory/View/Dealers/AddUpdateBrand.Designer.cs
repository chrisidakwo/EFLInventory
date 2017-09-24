namespace Inventory.View.Dealers {
    partial class AddUpdateBrand {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateBrand));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateBrand = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCreateBrand = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectBrand = new System.Windows.Forms.Label();
            this.ddlSelectBrand = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateBrand);
            this.panel1.Controls.Add(this.btnCreateBrand);
            this.panel1.Controls.Add(this.txtBrandName);
            this.panel1.Controls.Add(this.lblBrandName);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 199);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(177, 153);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateBrand.TabIndex = 6;
            this.btnUpdateBrand.Values.Text = "UPDATE";
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnCreateBrand
            // 
            this.btnCreateBrand.Location = new System.Drawing.Point(19, 153);
            this.btnCreateBrand.Name = "btnCreateBrand";
            this.btnCreateBrand.Size = new System.Drawing.Size(120, 32);
            this.btnCreateBrand.TabIndex = 5;
            this.btnCreateBrand.Values.Text = "CREATE NEW";
            this.btnCreateBrand.Click += new System.EventHandler(this.btnCreateBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(121, 101);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(180, 24);
            this.txtBrandName.TabIndex = 4;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(16, 107);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(85, 18);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "Brand Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectBrand);
            this.groupBox1.Controls.Add(this.ddlSelectBrand);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a Brand";
            // 
            // lblSelectBrand
            // 
            this.lblSelectBrand.AutoSize = true;
            this.lblSelectBrand.Location = new System.Drawing.Point(8, 38);
            this.lblSelectBrand.Name = "lblSelectBrand";
            this.lblSelectBrand.Size = new System.Drawing.Size(86, 18);
            this.lblSelectBrand.TabIndex = 0;
            this.lblSelectBrand.Text = "Select Brand:";
            // 
            // ddlSelectBrand
            // 
            this.ddlSelectBrand.FormattingEnabled = true;
            this.ddlSelectBrand.Location = new System.Drawing.Point(102, 32);
            this.ddlSelectBrand.Name = "ddlSelectBrand";
            this.ddlSelectBrand.Size = new System.Drawing.Size(164, 24);
            this.ddlSelectBrand.TabIndex = 1;
            this.ddlSelectBrand.SelectedIndexChanged += new System.EventHandler(this.ddlSelectBrand_SelectedIndexChanged);
            // 
            // AddUpdateBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUpdateBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateBrand";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectBrand;
        private System.Windows.Forms.ComboBox ddlSelectBrand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateBrand;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateBrand;
    }
}