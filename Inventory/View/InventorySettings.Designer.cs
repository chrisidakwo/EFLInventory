namespace Inventory.View {
    partial class InventorySettings {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMeasurementTypes = new System.Windows.Forms.Label();
            this.ddlMeasurementTypes = new System.Windows.Forms.ComboBox();
            this.lblMeasuringTypeName = new System.Windows.Forms.Label();
            this.txtMeasuringTypeName = new System.Windows.Forms.TextBox();
            this.btnSaveMeasurementType = new System.Windows.Forms.Button();
            this.btnDeleteMeasuringType = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 153);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMeasuringType);
            this.groupBox1.Controls.Add(this.btnSaveMeasurementType);
            this.groupBox1.Controls.Add(this.txtMeasuringTypeName);
            this.groupBox1.Controls.Add(this.lblMeasuringTypeName);
            this.groupBox1.Controls.Add(this.ddlMeasurementTypes);
            this.groupBox1.Controls.Add(this.lblMeasurementTypes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Measuring Type";
            // 
            // lblMeasurementTypes
            // 
            this.lblMeasurementTypes.AutoSize = true;
            this.lblMeasurementTypes.Location = new System.Drawing.Point(17, 45);
            this.lblMeasurementTypes.Name = "lblMeasurementTypes";
            this.lblMeasurementTypes.Size = new System.Drawing.Size(106, 18);
            this.lblMeasurementTypes.TabIndex = 0;
            this.lblMeasurementTypes.Text = "Measuring Units:";
            // 
            // ddlMeasurementTypes
            // 
            this.ddlMeasurementTypes.FormattingEnabled = true;
            this.ddlMeasurementTypes.Location = new System.Drawing.Point(144, 39);
            this.ddlMeasurementTypes.Name = "ddlMeasurementTypes";
            this.ddlMeasurementTypes.Size = new System.Drawing.Size(183, 24);
            this.ddlMeasurementTypes.TabIndex = 1;
            // 
            // lblMeasuringTypeName
            // 
            this.lblMeasuringTypeName.AutoSize = true;
            this.lblMeasuringTypeName.Location = new System.Drawing.Point(77, 76);
            this.lblMeasuringTypeName.Name = "lblMeasuringTypeName";
            this.lblMeasuringTypeName.Size = new System.Drawing.Size(46, 18);
            this.lblMeasuringTypeName.TabIndex = 2;
            this.lblMeasuringTypeName.Text = "Name:";
            // 
            // txtMeasuringTypeName
            // 
            this.txtMeasuringTypeName.Location = new System.Drawing.Point(144, 73);
            this.txtMeasuringTypeName.Name = "txtMeasuringTypeName";
            this.txtMeasuringTypeName.Size = new System.Drawing.Size(183, 24);
            this.txtMeasuringTypeName.TabIndex = 3;
            // 
            // btnSaveMeasurementType
            // 
            this.btnSaveMeasurementType.Location = new System.Drawing.Point(20, 111);
            this.btnSaveMeasurementType.Name = "btnSaveMeasurementType";
            this.btnSaveMeasurementType.Size = new System.Drawing.Size(148, 32);
            this.btnSaveMeasurementType.TabIndex = 4;
            this.btnSaveMeasurementType.Text = "SAVE";
            this.btnSaveMeasurementType.UseVisualStyleBackColor = true;
            this.btnSaveMeasurementType.Click += new System.EventHandler(this.btnSaveMeasurementType_Click);
            // 
            // btnDeleteMeasuringType
            // 
            this.btnDeleteMeasuringType.Location = new System.Drawing.Point(179, 111);
            this.btnDeleteMeasuringType.Name = "btnDeleteMeasuringType";
            this.btnDeleteMeasuringType.Size = new System.Drawing.Size(148, 32);
            this.btnDeleteMeasuringType.TabIndex = 5;
            this.btnDeleteMeasuringType.Text = "DELETE";
            this.btnDeleteMeasuringType.UseVisualStyleBackColor = true;
            this.btnDeleteMeasuringType.Click += new System.EventHandler(this.btnDeleteMeasuringType_Click);
            // 
            // InventorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventorySettings";
            this.Size = new System.Drawing.Size(715, 407);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlMeasurementTypes;
        private System.Windows.Forms.Label lblMeasurementTypes;
        private System.Windows.Forms.TextBox txtMeasuringTypeName;
        private System.Windows.Forms.Label lblMeasuringTypeName;
        private System.Windows.Forms.Button btnDeleteMeasuringType;
        private System.Windows.Forms.Button btnSaveMeasurementType;
    }
}
