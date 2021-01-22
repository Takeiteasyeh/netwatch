/* NetWatch by Ray Lynk
 * 
 * File:    LogView.cs
 * Purpose: Console replication for ping reply and status output.
 * Version: 1.0.1.0
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

namespace NetWatch_by_NGDevel.com
{
    public partial class LogView : Form
    {
        public delegate void dString(string message);
        private bool closing = false;

        public LogView()
        {
            InitializeComponent();
        }

        public void addToLog(string message)
        {
            if ((Program.updateLog == false) || (this.closing))
                return;

            if (this.InvokeRequired)
                this.Invoke((dString)this.addToLog, message);

            else
            {
                if (this.logViewer.Text.Length > 5000)
                    this.logViewer.Text = this.logViewer.Text.Remove(4000);

                this.logViewer.Text = message + "\r\n" + this.logViewer.Text;
                Program.pingBuffer = this.logViewer.Text;

                /* Update our counts */
                this.logSize.Text = Convert.ToString(this.logViewer.Text.Length) + " chars";
            }
        }

        private void clear(object sender, EventArgs e)
        {
            this.logViewer.Text = "";
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            this.closing = true;
            return;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Program.logView = new LogView();

            /* Check if there is a ping buffer */
            if (Program.pingBuffer.Length > 0)
            {
                Program.logView.addToLog(Program.pingBuffer);

            }
        }

        private void pauseUpdater(object sender, EventArgs e)
        {
            if (Program.updateLog)
            {
                //* Time to pause */
                this.pauseButton.Text = "Resume";
                Program.updateLog = false;
            }

            else
            {
                this.pauseButton.Text = "Pause";
                Program.updateLog = true;
            }

        }
    }
}
