using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Inventory.View {
    partial class Login {
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

        public static List<Bitmap> RandomBackgroundImage() {
            var _bgImages = new List<Bitmap>() {
                Properties.Resources.BG15A,
                Properties.Resources.sceneryC,
                Properties.Resources.LockScreen5A,
                Properties.Resources.sceneryA,
                Properties.Resources.BG15B,
                Properties.Resources.BG8A,
                Properties.Resources.sceneryB,
                Properties.Resources.BG12A,
                Properties.Resources.BG14A,
                Properties.Resources.BG21A,
                Properties.Resources.BG22A,
                Properties.Resources.BG23A,
                Properties.Resources.BG25A,
                Properties.Resources.BG26A,
            };

            return _bgImages;
        }

        int z = new Random().Next(0, (RandomBackgroundImage().Count - 1));


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxLoginGroup = new System.Windows.Forms.GroupBox();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmailAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.LoginTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxLoginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTableLayoutPanel
            // 
            this.LoginTableLayoutPanel.BackgroundImage = RandomBackgroundImage()[z];
            this.LoginTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginTableLayoutPanel.ColumnCount = 3;
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.LoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTableLayoutPanel.Name = "LoginTableLayoutPanel";
            this.LoginTableLayoutPanel.RowCount = 1;
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginTableLayoutPanel.Size = new System.Drawing.Size(718, 451);
            this.LoginTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(182, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 445);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.grpBoxLoginGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 305);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emi FoodLovers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Inventory.Properties.Resources.Updated_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(51, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxLoginGroup
            // 
            this.grpBoxLoginGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLoginGroup.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxLoginGroup.Controls.Add(this.btn_Login);
            this.grpBoxLoginGroup.Controls.Add(this.lblPassword);
            this.grpBoxLoginGroup.Controls.Add(this.txtPassword);
            this.grpBoxLoginGroup.Controls.Add(this.txtEmailAddress);
            this.grpBoxLoginGroup.Controls.Add(this.lblEmailAddress);
            this.grpBoxLoginGroup.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold);
            this.grpBoxLoginGroup.ForeColor = System.Drawing.Color.Black;
            this.grpBoxLoginGroup.Location = new System.Drawing.Point(13, 101);
            this.grpBoxLoginGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxLoginGroup.Name = "grpBoxLoginGroup";
            this.grpBoxLoginGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxLoginGroup.Size = new System.Drawing.Size(321, 178);
            this.grpBoxLoginGroup.TabIndex = 0;
            this.grpBoxLoginGroup.TabStop = false;
            this.grpBoxLoginGroup.Text = "ACCOUNT LOGIN";
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_Login.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(25, 126);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(274, 36);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Values.Text = "LOGIN";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(21, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "Password Input";
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Source Sans Pro Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(116, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(183, 23);
            this.txtPassword.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtPassword.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.txtPassword.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateNormal.Border.Width = 1;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAddress.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.txtEmailAddress.HideSelection = false;
            this.txtEmailAddress.Location = new System.Drawing.Point(116, 42);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(183, 23);
            this.txtEmailAddress.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtEmailAddress.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.txtEmailAddress.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmailAddress.StateNormal.Border.Width = 1;
            this.txtEmailAddress.TabIndex = 1;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.lblEmailAddress.Location = new System.Drawing.Point(45, 44);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(50, 20);
            this.lblEmailAddress.TabIndex = 0;
            this.lblEmailAddress.Text = "Email:";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.LoginTableLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(894, 610);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - EFL Inventory Management";
            this.LoginTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxLoginGroup.ResumeLayout(false);
            this.grpBoxLoginGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel LoginTableLayoutPanel;
        internal System.Windows.Forms.GroupBox grpBoxLoginGroup;
        internal System.Windows.Forms.Label lblEmailAddress;
        internal System.Windows.Forms.Label lblPassword;
        private KryptonTextBox txtEmailAddress;
        private KryptonTextBox txtPassword;
        private KryptonButton btn_Login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Button btnLogin;
    }
}