/* NetWatch by Ray Lynk
 * 
 * File:    Admin.cs
 * Purpose: Settings management screen
 * Version: 2.0.1.0
 * Author:  Ray Lynk
 * Email:   lynk@ngdevel.com
 * Website: http://netwatch.ngdevel.com
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NetWatch_by_NGDevel.com
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent(); 
        }

        /**
         * Someone clicked "Save" - Call settings save
         */
        private void settingsSave(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("Your settings have been saved.", "Settings saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();

        }

        private void loadDefaults(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to reset default settings?", "Confirm reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings have been reset to default values", "Default Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkWithWindows(object sender, FormClosingEventArgs e)
        {
            /* Ensure that we have the correct value in the registry */
            bool start = withWindows.IsAutoStartEnabled("NetWatch", Assembly.GetExecutingAssembly().Location);

            if (start != Properties.Settings.Default.withwindows)
            {
                if (Properties.Settings.Default.withwindows)
                    withWindows.SetAutoStart("NetWatch", Assembly.GetExecutingAssembly().Location);

                else
                    withWindows.UnSetAutoStart("NetWatch");
            }
        }
    }
}
