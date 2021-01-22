namespace NetWatch_by_NGDevel.com
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxLogSize = new System.Windows.Forms.Label();
            this.logSize = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.clearBox = new System.Windows.Forms.Button();
            this.logViewer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maxLogSize);
            this.groupBox1.Controls.Add(this.logSize);
            this.groupBox1.Controls.Add(this.pauseButton);
            this.groupBox1.Controls.Add(this.clearBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Controls";
            // 
            // maxLogSize
            // 
            this.maxLogSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLogSize.AutoSize = true;
            this.maxLogSize.Location = new System.Drawing.Point(429, 30);
            this.maxLogSize.Name = "maxLogSize";
            this.maxLogSize.Size = new System.Drawing.Size(60, 13);
            this.maxLogSize.TabIndex = 5;
            this.maxLogSize.Text = "5000 chars";
            // 
            // logSize
            // 
            this.logSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logSize.Location = new System.Drawing.Point(380, 30);
            this.logSize.Name = "logSize";
            this.logSize.Size = new System.Drawing.Size(43, 13);
            this.logSize.TabIndex = 4;
            this.logSize.Text = "0000";
            this.logSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(89, 20);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "&Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseUpdater);
            // 
            // clearBox
            // 
            this.clearBox.Location = new System.Drawing.Point(7, 20);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(75, 23);
            this.clearBox.TabIndex = 0;
            this.clearBox.Text = "&Clear";
            this.clearBox.UseVisualStyleBackColor = true;
            this.clearBox.Click += new System.EventHandler(this.clear);
            // 
            // logViewer
            // 
            this.logViewer.BackColor = System.Drawing.Color.Black;
            this.logViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logViewer.ForeColor = System.Drawing.Color.White;
            this.logViewer.Location = new System.Drawing.Point(0, 0);
            this.logViewer.Multiline = true;
            this.logViewer.Name = "logViewer";
            this.logViewer.ReadOnly = true;
            this.logViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logViewer.Size = new System.Drawing.Size(495, 259);
            this.logViewer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 309);
            this.Controls.Add(this.logViewer);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogView";
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearBox;
        private System.Windows.Forms.TextBox logViewer;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label maxLogSize;
        private System.Windows.Forms.Label logSize;
        private System.Windows.Forms.Label label1;
    }
}