namespace ToastNotification {
    partial class Notification {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.labelBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // labelBody
            // 
            this.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBody.AutoSize = true;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelBody.ForeColor = System.Drawing.Color.White;
            this.labelBody.Location = new System.Drawing.Point(11, 53);
            this.labelBody.MaximumSize = new System.Drawing.Size(345, 130);
            this.labelBody.MinimumSize = new System.Drawing.Size(339, 19);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(339, 19);
            this.labelBody.TabIndex = 0;
            this.labelBody.Text = "Body goes here and here and here and here and here";
            this.labelBody.Click += new System.EventHandler(this.labelRO_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(11, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(283, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "TITLE GOES HERE";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Inventory.Properties.Resources.ToastNotification1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 128);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBody);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(370, 200);
            this.MinimumSize = new System.Drawing.Size(370, 120);
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer lifeTimer;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelTitle;
    }
}