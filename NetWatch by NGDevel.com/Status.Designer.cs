namespace NetWatch_by_NGDevel.com
{
    partial class Status
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
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.statusActionString = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.DarkRed;
            this.statusBar.Location = new System.Drawing.Point(22, 35);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(436, 10);
            this.statusBar.TabIndex = 2;
            this.statusBar.UseWaitCursor = true;
            // 
            // statusActionString
            // 
            this.statusActionString.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusActionString.Location = new System.Drawing.Point(18, 9);
            this.statusActionString.Name = "statusActionString";
            this.statusActionString.Size = new System.Drawing.Size(438, 23);
            this.statusActionString.TabIndex = 3;
            this.statusActionString.Text = "Waiting...";
            this.statusActionString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(368, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Netwatch 2.0";
            // 
            // currentValue
            // 
            this.currentValue.AutoSize = true;
            this.currentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValue.Location = new System.Drawing.Point(22, 48);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(30, 17);
            this.currentValue.TabIndex = 5;
            this.currentValue.Text = "0%";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 68);
            this.ControlBox = false;
            this.Controls.Add(this.currentValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusActionString);
            this.Controls.Add(this.statusBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Status";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetWatch Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Label statusActionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentValue;


    }
}