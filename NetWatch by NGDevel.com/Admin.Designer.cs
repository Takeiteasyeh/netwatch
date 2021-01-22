namespace NetWatch_by_NGDevel.com
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.threshHigh = new System.Windows.Forms.TextBox();
            this.threshModerate = new System.Windows.Forms.TextBox();
            this.threshLow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.threshNotifyHigh = new System.Windows.Forms.CheckBox();
            this.threshNotifyModerate = new System.Windows.Forms.CheckBox();
            this.threshNotifyLow = new System.Windows.Forms.CheckBox();
            this.setting_startwin = new System.Windows.Forms.CheckBox();
            this.settingNotifyDisconnect = new System.Windows.Forms.CheckBox();
            this.setting_notifyConnect = new System.Windows.Forms.CheckBox();
            this.threshNotifyNoReply = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setting_startwin);
            this.groupBox1.Controls.Add(this.settingNotifyDisconnect);
            this.groupBox1.Controls.Add(this.setting_notifyConnect);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.threshNotifyNoReply);
            this.groupBox3.Controls.Add(this.threshNotifyHigh);
            this.groupBox3.Controls.Add(this.threshNotifyModerate);
            this.groupBox3.Controls.Add(this.threshNotifyLow);
            this.groupBox3.Controls.Add(this.threshHigh);
            this.groupBox3.Controls.Add(this.threshModerate);
            this.groupBox3.Controls.Add(this.threshLow);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(2, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thresholds";
            // 
            // threshHigh
            // 
            this.threshHigh.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "threshHigh", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshHigh.Location = new System.Drawing.Point(71, 58);
            this.threshHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.threshHigh.Name = "threshHigh";
            this.threshHigh.Size = new System.Drawing.Size(34, 20);
            this.threshHigh.TabIndex = 5;
            this.threshHigh.Text = "1000";
            this.threshHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // threshModerate
            // 
            this.threshModerate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "threshMod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshModerate.Location = new System.Drawing.Point(71, 43);
            this.threshModerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.threshModerate.Name = "threshModerate";
            this.threshModerate.Size = new System.Drawing.Size(34, 20);
            this.threshModerate.TabIndex = 4;
            this.threshModerate.Text = "250";
            this.threshModerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // threshLow
            // 
            this.threshLow.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "threshLow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshLow.Location = new System.Drawing.Point(71, 27);
            this.threshLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.threshLow.Name = "threshLow";
            this.threshLow.Size = new System.Drawing.Size(34, 20);
            this.threshLow.TabIndex = 3;
            this.threshLow.Text = "130";
            this.threshLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "High:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moderate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(2, 256);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Close";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.Location = new System.Drawing.Point(84, 256);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 25);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.settingsSave);
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.Location = new System.Drawing.Point(2, 285);
            this.buttonDefaults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(166, 22);
            this.buttonDefaults.TabIndex = 5;
            this.buttonDefaults.Text = "Load &Defaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.loadDefaults);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clicking \"Close\" makes changes temporary.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // threshNotifyHigh
            // 
            this.threshNotifyHigh.AutoSize = true;
            this.threshNotifyHigh.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyHigh;
            this.threshNotifyHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threshNotifyHigh.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyHigh", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshNotifyHigh.Location = new System.Drawing.Point(110, 62);
            this.threshNotifyHigh.Margin = new System.Windows.Forms.Padding(2);
            this.threshNotifyHigh.Name = "threshNotifyHigh";
            this.threshNotifyHigh.Size = new System.Drawing.Size(53, 17);
            this.threshNotifyHigh.TabIndex = 8;
            this.threshNotifyHigh.Text = "Notify";
            this.threshNotifyHigh.UseVisualStyleBackColor = true;
            // 
            // threshNotifyModerate
            // 
            this.threshNotifyModerate.AutoSize = true;
            this.threshNotifyModerate.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyMod;
            this.threshNotifyModerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threshNotifyModerate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyMod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshNotifyModerate.Location = new System.Drawing.Point(110, 45);
            this.threshNotifyModerate.Margin = new System.Windows.Forms.Padding(2);
            this.threshNotifyModerate.Name = "threshNotifyModerate";
            this.threshNotifyModerate.Size = new System.Drawing.Size(53, 17);
            this.threshNotifyModerate.TabIndex = 7;
            this.threshNotifyModerate.Text = "Notify";
            this.threshNotifyModerate.UseVisualStyleBackColor = true;
            // 
            // threshNotifyLow
            // 
            this.threshNotifyLow.AutoSize = true;
            this.threshNotifyLow.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyLow;
            this.threshNotifyLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threshNotifyLow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyLow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshNotifyLow.Location = new System.Drawing.Point(110, 27);
            this.threshNotifyLow.Margin = new System.Windows.Forms.Padding(2);
            this.threshNotifyLow.Name = "threshNotifyLow";
            this.threshNotifyLow.Size = new System.Drawing.Size(53, 17);
            this.threshNotifyLow.TabIndex = 6;
            this.threshNotifyLow.Text = "Notify";
            this.threshNotifyLow.UseVisualStyleBackColor = true;
            // 
            // setting_startwin
            // 
            this.setting_startwin.AutoSize = true;
            this.setting_startwin.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.withwindows;
            this.setting_startwin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "withwindows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.setting_startwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_startwin.ForeColor = System.Drawing.Color.Green;
            this.setting_startwin.Location = new System.Drawing.Point(12, 60);
            this.setting_startwin.Name = "setting_startwin";
            this.setting_startwin.Size = new System.Drawing.Size(129, 19);
            this.setting_startwin.TabIndex = 0;
            this.setting_startwin.Text = "Start with Windows";
            this.setting_startwin.UseVisualStyleBackColor = true;
            // 
            // settingNotifyDisconnect
            // 
            this.settingNotifyDisconnect.AutoSize = true;
            this.settingNotifyDisconnect.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyOnDisconnect;
            this.settingNotifyDisconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingNotifyDisconnect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyOnDisconnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingNotifyDisconnect.Location = new System.Drawing.Point(12, 37);
            this.settingNotifyDisconnect.Name = "settingNotifyDisconnect";
            this.settingNotifyDisconnect.Size = new System.Drawing.Size(139, 17);
            this.settingNotifyDisconnect.TabIndex = 1;
            this.settingNotifyDisconnect.Text = "Notify on Disconnection";
            this.settingNotifyDisconnect.UseVisualStyleBackColor = true;
            // 
            // setting_notifyConnect
            // 
            this.setting_notifyConnect.AutoSize = true;
            this.setting_notifyConnect.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyOnConnect;
            this.setting_notifyConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setting_notifyConnect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyOnConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.setting_notifyConnect.Location = new System.Drawing.Point(12, 20);
            this.setting_notifyConnect.Name = "setting_notifyConnect";
            this.setting_notifyConnect.Size = new System.Drawing.Size(125, 17);
            this.setting_notifyConnect.TabIndex = 0;
            this.setting_notifyConnect.Text = "Notify on Connection";
            this.setting_notifyConnect.UseVisualStyleBackColor = true;
            // 
            // threshNotifyNoReply
            // 
            this.threshNotifyNoReply.AutoSize = true;
            this.threshNotifyNoReply.Checked = global::NetWatch_by_NGDevel.com.Properties.Settings.Default.notifyDrop;
            this.threshNotifyNoReply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threshNotifyNoReply.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetWatch_by_NGDevel.com.Properties.Settings.Default, "notifyDrop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.threshNotifyNoReply.Location = new System.Drawing.Point(30, 133);
            this.threshNotifyNoReply.Margin = new System.Windows.Forms.Padding(2);
            this.threshNotifyNoReply.Name = "threshNotifyNoReply";
            this.threshNotifyNoReply.Size = new System.Drawing.Size(108, 17);
            this.threshNotifyNoReply.TabIndex = 9;
            this.threshNotifyNoReply.Text = "Notify on no-reply";
            this.threshNotifyNoReply.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(174, 343);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDefaults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetWatch Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkWithWindows);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox settingNotifyDisconnect;
        private System.Windows.Forms.CheckBox setting_notifyConnect;
        private System.Windows.Forms.CheckBox setting_startwin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox threshHigh;
        private System.Windows.Forms.TextBox threshModerate;
        private System.Windows.Forms.TextBox threshLow;
        private System.Windows.Forms.CheckBox threshNotifyHigh;
        private System.Windows.Forms.CheckBox threshNotifyModerate;
        private System.Windows.Forms.CheckBox threshNotifyLow;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox threshNotifyNoReply;
    }
}