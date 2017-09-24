using ComponentFactory.Krypton.Toolkit;

namespace Inventory.View.Products {
    partial class AddUpdateProductVariation {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateProductVariation));
            this.ddlSelectProduct = new System.Windows.Forms.ComboBox();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.lblProdVariationName = new System.Windows.Forms.Label();
            this.txtProdVariationName = new System.Windows.Forms.TextBox();
            this.lblProdMeasuredBy = new System.Windows.Forms.Label();
            this.ddlProdMeasuredBy = new System.Windows.Forms.ComboBox();
            this.txtProdVariationWeight = new System.Windows.Forms.NumericUpDown();
            this.lblProdVariationWeight = new System.Windows.Forms.Label();
            this.lblProdVariationCostPrice = new System.Windows.Forms.Label();
            this.lblProdVariationSalePrice = new System.Windows.Forms.Label();
            this.txtProdVariationSalePrice = new System.Windows.Forms.NumericUpDown();
            this.txtProdVariationCostPrice = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new KryptonButton();
            this.btnSaveProductVariation = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationCostPrice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlSelectProduct
            // 
            this.ddlSelectProduct.FormattingEnabled = true;
            this.ddlSelectProduct.Location = new System.Drawing.Point(151, 12);
            this.ddlSelectProduct.Name = "ddlSelectProduct";
            this.ddlSelectProduct.Size = new System.Drawing.Size(193, 24);
            this.ddlSelectProduct.TabIndex = 0;
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(23, 18);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(98, 18);
            this.lblSelectProduct.TabIndex = 1;
            this.lblSelectProduct.Text = "Select Product:";
            // 
            // lblProdVariationName
            // 
            this.lblProdVariationName.AutoSize = true;
            this.lblProdVariationName.Location = new System.Drawing.Point(19, 49);
            this.lblProdVariationName.Name = "lblProdVariationName";
            this.lblProdVariationName.Size = new System.Drawing.Size(102, 18);
            this.lblProdVariationName.TabIndex = 2;
            this.lblProdVariationName.Text = "Variation Name:";
            // 
            // txtProdVariationName
            // 
            this.txtProdVariationName.Location = new System.Drawing.Point(151, 43);
            this.txtProdVariationName.Name = "txtProdVariationName";
            this.txtProdVariationName.Size = new System.Drawing.Size(193, 24);
            this.txtProdVariationName.TabIndex = 3;
            // 
            // lblProdMeasuredBy
            // 
            this.lblProdMeasuredBy.AutoSize = true;
            this.lblProdMeasuredBy.Location = new System.Drawing.Point(34, 81);
            this.lblProdMeasuredBy.Name = "lblProdMeasuredBy";
            this.lblProdMeasuredBy.Size = new System.Drawing.Size(87, 18);
            this.lblProdMeasuredBy.TabIndex = 4;
            this.lblProdMeasuredBy.Text = "Measured By:";
            // 
            // ddlProdMeasuredBy
            // 
            this.ddlProdMeasuredBy.FormattingEnabled = true;
            this.ddlProdMeasuredBy.Location = new System.Drawing.Point(151, 75);
            this.ddlProdMeasuredBy.Name = "ddlProdMeasuredBy";
            this.ddlProdMeasuredBy.Size = new System.Drawing.Size(193, 24);
            this.ddlProdMeasuredBy.TabIndex = 5;
            // 
            // txtProdVariationWeight
            // 
            this.txtProdVariationWeight.DecimalPlaces = 2;
            this.txtProdVariationWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProdVariationWeight.Location = new System.Drawing.Point(151, 107);
            this.txtProdVariationWeight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdVariationWeight.Name = "txtProdVariationWeight";
            this.txtProdVariationWeight.Size = new System.Drawing.Size(193, 24);
            this.txtProdVariationWeight.TabIndex = 6;
            // 
            // lblProdVariationWeight
            // 
            this.lblProdVariationWeight.AutoSize = true;
            this.lblProdVariationWeight.Location = new System.Drawing.Point(69, 113);
            this.lblProdVariationWeight.Name = "lblProdVariationWeight";
            this.lblProdVariationWeight.Size = new System.Drawing.Size(52, 18);
            this.lblProdVariationWeight.TabIndex = 7;
            this.lblProdVariationWeight.Text = "Weight:";
            // 
            // lblProdVariationCostPrice
            // 
            this.lblProdVariationCostPrice.AutoSize = true;
            this.lblProdVariationCostPrice.Location = new System.Drawing.Point(51, 177);
            this.lblProdVariationCostPrice.Name = "lblProdVariationCostPrice";
            this.lblProdVariationCostPrice.Size = new System.Drawing.Size(70, 18);
            this.lblProdVariationCostPrice.TabIndex = 8;
            this.lblProdVariationCostPrice.Text = "Cost Price:";
            // 
            // lblProdVariationSalePrice
            // 
            this.lblProdVariationSalePrice.AutoSize = true;
            this.lblProdVariationSalePrice.Location = new System.Drawing.Point(53, 145);
            this.lblProdVariationSalePrice.Name = "lblProdVariationSalePrice";
            this.lblProdVariationSalePrice.Size = new System.Drawing.Size(68, 18);
            this.lblProdVariationSalePrice.TabIndex = 9;
            this.lblProdVariationSalePrice.Text = "Sale Price:";
            // 
            // txtProdVariationSalePrice
            // 
            this.txtProdVariationSalePrice.DecimalPlaces = 2;
            this.txtProdVariationSalePrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProdVariationSalePrice.Location = new System.Drawing.Point(151, 139);
            this.txtProdVariationSalePrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdVariationSalePrice.Name = "txtProdVariationSalePrice";
            this.txtProdVariationSalePrice.Size = new System.Drawing.Size(193, 24);
            this.txtProdVariationSalePrice.TabIndex = 11;
            // 
            // txtProdVariationCostPrice
            // 
            this.txtProdVariationCostPrice.DecimalPlaces = 2;
            this.txtProdVariationCostPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtProdVariationCostPrice.Location = new System.Drawing.Point(151, 171);
            this.txtProdVariationCostPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtProdVariationCostPrice.Name = "txtProdVariationCostPrice";
            this.txtProdVariationCostPrice.Size = new System.Drawing.Size(193, 24);
            this.txtProdVariationCostPrice.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 273);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProdVariationCostPrice);
            this.panel1.Controls.Add(this.txtProdVariationName);
            this.panel1.Controls.Add(this.lblSelectProduct);
            this.panel1.Controls.Add(this.ddlProdMeasuredBy);
            this.panel1.Controls.Add(this.txtProdVariationSalePrice);
            this.panel1.Controls.Add(this.lblProdMeasuredBy);
            this.panel1.Controls.Add(this.ddlSelectProduct);
            this.panel1.Controls.Add(this.lblProdVariationWeight);
            this.panel1.Controls.Add(this.lblProdVariationSalePrice);
            this.panel1.Controls.Add(this.txtProdVariationWeight);
            this.panel1.Controls.Add(this.lblProdVariationName);
            this.panel1.Controls.Add(this.lblProdVariationCostPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSaveProductVariation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveProductVariation
            // 
            this.btnSaveProductVariation.Location = new System.Drawing.Point(22, 8);
            this.btnSaveProductVariation.Name = "btnSaveProductVariation";
            this.btnSaveProductVariation.Size = new System.Drawing.Size(148, 32);
            this.btnSaveProductVariation.TabIndex = 0;
            this.btnSaveProductVariation.Text = "SAVE";
            this.btnSaveProductVariation.Click += new System.EventHandler(this.btnSaveProductVariation_Click);
            // 
            // AddUpdateProductVariation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(389, 327);
            this.Name = "AddUpdateProductVariation";
            this.Padding = new System.Windows.Forms.Padding(25, 74, 25, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Update Product Variations";
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdVariationCostPrice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlSelectProduct;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.Label lblProdVariationName;
        private System.Windows.Forms.TextBox txtProdVariationName;
        private System.Windows.Forms.Label lblProdMeasuredBy;
        private System.Windows.Forms.ComboBox ddlProdMeasuredBy;
        private System.Windows.Forms.NumericUpDown txtProdVariationWeight;
        private System.Windows.Forms.Label lblProdVariationWeight;
        private System.Windows.Forms.Label lblProdVariationCostPrice;
        private System.Windows.Forms.Label lblProdVariationSalePrice;
        private System.Windows.Forms.NumericUpDown txtProdVariationSalePrice;
        private System.Windows.Forms.NumericUpDown txtProdVariationCostPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private KryptonButton btnCancel;
        private KryptonButton btnSaveProductVariation;
    }
}