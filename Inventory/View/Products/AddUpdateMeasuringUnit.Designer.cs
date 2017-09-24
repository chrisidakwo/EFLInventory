namespace Inventory.View.Products {
    partial class AddUpdateMeasuringUnit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateMeasuringUnit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateMeasuringUnit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCreateMeasuringUnit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectMeasuringUnit = new System.Windows.Forms.Label();
            this.ddlSelectMeasuringUnit = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.btnUpdateMeasuringUnit);
            this.panel1.Controls.Add(this.btnCreateMeasuringUnit);
            this.panel1.Controls.Add(this.txtUnitName);
            this.panel1.Controls.Add(this.lblUnitName);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 199);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateMeasuringUnit
            // 
            this.btnUpdateMeasuringUnit.Location = new System.Drawing.Point(181, 155);
            this.btnUpdateMeasuringUnit.Name = "btnUpdateMeasuringUnit";
            this.btnUpdateMeasuringUnit.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateMeasuringUnit.TabIndex = 8;
            this.btnUpdateMeasuringUnit.Values.Text = "UPDATE";
            this.btnUpdateMeasuringUnit.Click += new System.EventHandler(this.btnUpdateMeasuringUnit_Click);
            // 
            // btnCreateMeasuringUnit
            // 
            this.btnCreateMeasuringUnit.Location = new System.Drawing.Point(19, 155);
            this.btnCreateMeasuringUnit.Name = "btnCreateMeasuringUnit";
            this.btnCreateMeasuringUnit.Size = new System.Drawing.Size(120, 32);
            this.btnCreateMeasuringUnit.TabIndex = 7;
            this.btnCreateMeasuringUnit.Values.Text = "CREATE NEW";
            this.btnCreateMeasuringUnit.Click += new System.EventHandler(this.btnCreateMeasuringUnit_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(133, 101);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(168, 24);
            this.txtUnitName.TabIndex = 6;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(16, 107);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(100, 18);
            this.lblUnitName.TabIndex = 5;
            this.lblUnitName.Text = "Measuring Unit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectMeasuringUnit);
            this.groupBox1.Controls.Add(this.ddlSelectMeasuringUnit);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update  a Measuring Unit";
            // 
            // lblSelectMeasuringUnit
            // 
            this.lblSelectMeasuringUnit.AutoSize = true;
            this.lblSelectMeasuringUnit.Location = new System.Drawing.Point(8, 38);
            this.lblSelectMeasuringUnit.Name = "lblSelectMeasuringUnit";
            this.lblSelectMeasuringUnit.Size = new System.Drawing.Size(75, 18);
            this.lblSelectMeasuringUnit.TabIndex = 0;
            this.lblSelectMeasuringUnit.Text = "Select Unit:";
            // 
            // ddlSelectMeasuringUnit
            // 
            this.ddlSelectMeasuringUnit.FormattingEnabled = true;
            this.ddlSelectMeasuringUnit.Location = new System.Drawing.Point(102, 32);
            this.ddlSelectMeasuringUnit.Name = "ddlSelectMeasuringUnit";
            this.ddlSelectMeasuringUnit.Size = new System.Drawing.Size(164, 24);
            this.ddlSelectMeasuringUnit.TabIndex = 1;
            this.ddlSelectMeasuringUnit.SelectedIndexChanged += new System.EventHandler(this.ddlSelectMeasuringUnit_SelectedIndexChanged);
            // 
            // AddUpdateMeasuringUnit
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
            this.Name = "AddUpdateMeasuringUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateMeasuringUnit";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectMeasuringUnit;
        private System.Windows.Forms.ComboBox ddlSelectMeasuringUnit;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateMeasuringUnit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateMeasuringUnit;
    }
}