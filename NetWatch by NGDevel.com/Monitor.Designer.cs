namespace NetWatch_by_NGDevel.com
{
    partial class Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
			this.lastminutebox = new System.Windows.Forms.GroupBox();
			this.currentHost = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.minute_percent = new System.Windows.Forms.Label();
			this.progress_last_minute = new System.Windows.Forms.ProgressBar();
			this.valueLabel = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.lowMedLastLabel = new System.Windows.Forms.Label();
			this.imgUpDown = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lastminutebox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lastminutebox
			// 
			this.lastminutebox.Controls.Add(this.currentHost);
			this.lastminutebox.Controls.Add(this.label6);
			this.lastminutebox.Controls.Add(this.pictureBox1);
			this.lastminutebox.Controls.Add(this.minute_percent);
			this.lastminutebox.Controls.Add(this.progress_last_minute);
			this.lastminutebox.Location = new System.Drawing.Point(3, 5);
			this.lastminutebox.Name = "lastminutebox";
			this.lastminutebox.Size = new System.Drawing.Size(293, 65);
			this.lastminutebox.TabIndex = 0;
			this.lastminutebox.TabStop = false;
			this.lastminutebox.Text = "Current Network Health:";
			// 
			// currentHost
			// 
			this.currentHost.ForeColor = System.Drawing.Color.RoyalBlue;
			this.currentHost.Location = new System.Drawing.Point(62, 43);
			this.currentHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.currentHost.Name = "currentHost";
			this.currentHost.Size = new System.Drawing.Size(188, 19);
			this.currentHost.TabIndex = 9;
			this.currentHost.Text = "No host yet";
			this.currentHost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(255, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "100%";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::NetWatch_by_NGDevel.com.Properties.Resources.heart;
			this.pictureBox1.Location = new System.Drawing.Point(9, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// minute_percent
			// 
			this.minute_percent.Location = new System.Drawing.Point(33, 41);
			this.minute_percent.Name = "minute_percent";
			this.minute_percent.Size = new System.Drawing.Size(24, 18);
			this.minute_percent.TabIndex = 5;
			this.minute_percent.Text = "0%";
			this.minute_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progress_last_minute
			// 
			this.progress_last_minute.BackColor = System.Drawing.SystemColors.Control;
			this.progress_last_minute.Location = new System.Drawing.Point(36, 28);
			this.progress_last_minute.Name = "progress_last_minute";
			this.progress_last_minute.Size = new System.Drawing.Size(249, 10);
			this.progress_last_minute.TabIndex = 0;
			// 
			// valueLabel
			// 
			this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.valueLabel.ForeColor = System.Drawing.Color.Black;
			this.valueLabel.Location = new System.Drawing.Point(155, 77);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new System.Drawing.Size(50, 23);
			this.valueLabel.TabIndex = 8;
			this.valueLabel.Text = "0%";
			this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipTitle = "Current Network Health";
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "NetWatch";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(3, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 18);
			this.label1.TabIndex = 11;
			this.label1.Text = "Low / Median / High / Last";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lowMedLastLabel
			// 
			this.lowMedLastLabel.BackColor = System.Drawing.Color.Black;
			this.lowMedLastLabel.ForeColor = System.Drawing.Color.Lime;
			this.lowMedLastLabel.Location = new System.Drawing.Point(3, 88);
			this.lowMedLastLabel.Name = "lowMedLastLabel";
			this.lowMedLastLabel.Size = new System.Drawing.Size(146, 16);
			this.lowMedLastLabel.TabIndex = 12;
			this.lowMedLastLabel.Text = " 65 / 122 / 87 /134";
			this.lowMedLastLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// imgUpDown
			// 
			this.imgUpDown.Image = global::NetWatch_by_NGDevel.com.Properties.Resources.arrow_up;
			this.imgUpDown.Location = new System.Drawing.Point(205, 79);
			this.imgUpDown.Name = "imgUpDown";
			this.imgUpDown.Size = new System.Drawing.Size(20, 22);
			this.imgUpDown.TabIndex = 13;
			this.imgUpDown.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::NetWatch_by_NGDevel.com.Properties.Resources.console;
			this.pictureBox3.Location = new System.Drawing.Point(240, 77);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(28, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.launchLog);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::NetWatch_by_NGDevel.com.Properties.Resources.config;
			this.pictureBox2.Location = new System.Drawing.Point(272, 77);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.startSetupScreen);
			// 
			// Monitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(300, 104);
			this.Controls.Add(this.imgUpDown);
			this.Controls.Add(this.lowMedLastLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.valueLabel);
			this.Controls.Add(this.lastminutebox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Monitor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NetWatch v2.2";
			this.lastminutebox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lastminutebox;
        private System.Windows.Forms.ProgressBar progress_last_minute;
        private System.Windows.Forms.Label minute_percent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label currentHost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lowMedLastLabel;
        private System.Windows.Forms.PictureBox imgUpDown;
    }
}

