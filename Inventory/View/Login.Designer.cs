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
            this.grpBoxLoginGroup = new System.Windows.Forms.GroupBox();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmailAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserAcctConfig = new System.Windows.Forms.LinkLabel();
            this.LoginTableLayoutPanel.SuspendLayout();
            this.grpBoxLoginGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTableLayoutPanel
            // 
            this.LoginTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginTableLayoutPanel.ColumnCount = 3;
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.94798F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.05202F));
            this.LoginTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.LoginTableLayoutPanel.Controls.Add(this.grpBoxLoginGroup, 1, 1);
            this.LoginTableLayoutPanel.Controls.Add(this.panel1, 1, 2);
            this.LoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTableLayoutPanel.Name = "LoginTableLayoutPanel";
            this.LoginTableLayoutPanel.RowCount = 3;
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.35484F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.64516F));
            this.LoginTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.LoginTableLayoutPanel.Size = new System.Drawing.Size(718, 451);
            this.LoginTableLayoutPanel.TabIndex = 0;
            // 
            // grpBoxLoginGroup
            // 
            this.grpBoxLoginGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLoginGroup.Controls.Add(this.btn_Login);
            this.grpBoxLoginGroup.Controls.Add(this.lblPassword);
            this.grpBoxLoginGroup.Controls.Add(this.txtPassword);
            this.grpBoxLoginGroup.Controls.Add(this.txtEmailAddress);
            this.grpBoxLoginGroup.Controls.Add(this.lblEmailAddress);
            this.grpBoxLoginGroup.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.grpBoxLoginGroup.ForeColor = System.Drawing.Color.White;
            this.grpBoxLoginGroup.Location = new System.Drawing.Point(176, 126);
            this.grpBoxLoginGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxLoginGroup.Name = "grpBoxLoginGroup";
            this.grpBoxLoginGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxLoginGroup.Size = new System.Drawing.Size(347, 180);
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
            this.btn_Login.Size = new System.Drawing.Size(300, 38);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Values.Text = "LOGIN";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Source Sans Pro", 12F);
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
            this.txtPassword.Location = new System.Drawing.Point(116, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(209, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAddress.Font = new System.Drawing.Font("Source Sans Pro", 11F);
            this.txtEmailAddress.Location = new System.Drawing.Point(116, 42);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(209, 23);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.lblEmailAddress.Location = new System.Drawing.Point(45, 44);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(50, 20);
            this.lblEmailAddress.TabIndex = 0;
            this.lblEmailAddress.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserAcctConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(176, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 135);
            this.panel1.TabIndex = 1;
            // 
            // lblUserAcctConfig
            // 
            this.lblUserAcctConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.lblUserAcctConfig.ActiveLinkColor = System.Drawing.Color.White;
            this.lblUserAcctConfig.AutoSize = true;
            this.lblUserAcctConfig.BackColor = System.Drawing.Color.Transparent;
            this.lblUserAcctConfig.DisabledLinkColor = System.Drawing.Color.White;
            this.lblUserAcctConfig.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.lblUserAcctConfig.ForeColor = System.Drawing.Color.White;
            this.lblUserAcctConfig.LinkColor = System.Drawing.Color.White;
            this.lblUserAcctConfig.Location = new System.Drawing.Point(86, 111);
            this.lblUserAcctConfig.Name = "lblUserAcctConfig";
            this.lblUserAcctConfig.Size = new System.Drawing.Size(172, 18);
            this.lblUserAcctConfig.TabIndex = 0;
            this.lblUserAcctConfig.TabStop = true;
            this.lblUserAcctConfig.Text = "User Account Configuration";
            this.lblUserAcctConfig.Visible = false;
            this.lblUserAcctConfig.VisitedLinkColor = System.Drawing.Color.White;
            this.lblUserAcctConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUserAcctConfig_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BackgroundImage = RandomBackgroundImage()[z];
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
            this.grpBoxLoginGroup.ResumeLayout(false);
            this.grpBoxLoginGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblUserAcctConfig;
        //private System.Windows.Forms.Button btnLogin;
    }
}