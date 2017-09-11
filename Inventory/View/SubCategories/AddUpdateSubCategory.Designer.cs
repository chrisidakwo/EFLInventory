namespace Inventory.View.SubCategories {
    partial class AddUpdateSubCategory {
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
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.txtSubCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddSubCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategoryName.AutoSize = true;
            this.lblSubCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.lblSubCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblSubCategoryName.Location = new System.Drawing.Point(25, 42);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(52, 20);
            this.lblSubCategoryName.TabIndex = 0;
            this.lblSubCategoryName.Text = "Name:";
            // 
            // txtSubCategoryName
            // 
            this.txtSubCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubCategoryName.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.txtSubCategoryName.Location = new System.Drawing.Point(102, 42);
            this.txtSubCategoryName.Name = "txtSubCategoryName";
            this.txtSubCategoryName.Size = new System.Drawing.Size(241, 24);
            this.txtSubCategoryName.TabIndex = 1;
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.btnAddSubCategory.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.btnAddSubCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddSubCategory.Location = new System.Drawing.Point(29, 88);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(148, 35);
            this.btnAddSubCategory.TabIndex = 2;
            this.btnAddSubCategory.Text = "SAVE";
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(195, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUpdateSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(373, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSubCategory);
            this.Controls.Add(this.txtSubCategoryName);
            this.Controls.Add(this.lblSubCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(389, 200);
            this.MinimumSize = new System.Drawing.Size(389, 200);
            this.Name = "AddUpdateSubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update SubCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblSubCategoryName;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnAddSubCategory;
        internal System.Windows.Forms.TextBox txtSubCategoryName;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
    }
}