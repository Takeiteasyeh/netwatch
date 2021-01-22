/* NetWatch by Ray Lynk
 * 
 * File:    Monitor.cs
 * Purpose: Main form application.
 * Version: 2.0.2.0
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
using System.Threading;

namespace NetWatch_by_NGDevel.com
{
    public partial class Monitor : Form
    {
        protected Thread t;
        public delegate void dVoid();
        public delegate void dString(string host);
        public delegate void dPingEvent(object o, PingEvent e);

        public Monitor()
        {
        
            InitializeComponent();
        }

        public void start()
        {
            this.t = new Thread(new ThreadStart(PingCheck.Start));
            this.t.Name = "Ping thread";
            this.t.IsBackground = true; //mark as true or app never really ends!!
            this.t.SetApartmentState(ApartmentState.STA);
            this.t.Start();
            PingCheck.PingReply += new EventHandler<PingEvent>(PingCheck_PingReply);
            PingCheck.PingNoReply += new EventHandler<PingEvent>(PingCheck_PingNoReply);
        }

        void PingCheck_PingNoReply(object sender, PingEvent args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((dPingEvent)PingCheck_PingNoReply, sender, args);
                return;
            }

            this.lowMedLastLabel.Text = String.Format("{0} / {1} / {2} / --", args.LowestPing, args.MedianPing, args.HighestPing);

        }

        void PingCheck_PingReply(object sender, PingEvent args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((dPingEvent)PingCheck_PingReply, sender, args);
                return;
            }

            this.lowMedLastLabel.Text = String.Format("{0} / {1} / {2} / {3}", args.LowestPing, args.MedianPing, args.HighestPing, args.LastPing);

        }

        public void openWindow()
        {
            if (this.InvokeRequired)
                this.Invoke((dVoid)this.openWindow);

            else
            {
                this.Show();
            }
        }

        private void launchLog(object sender, EventArgs e)
        {

            Program.logView.Show();
        }

        public void setHostString(string host)
        {
            if (this.InvokeRequired)
                this.Invoke((dString)this.setHostString, host);

            else
            {
                this.currentHost.Text = host;
            }
        }

        public void updateMonitor()
        {
            if (this.InvokeRequired)
                this.Invoke((dVoid)this.updateMonitor);

            else
            {
                /* Set our base, if we are offline, its easy */
                if (!Memory.networkup)
                {
                    this.progress_last_minute.Value = 0;
                    this.valueLabel.Text = "0%";
                    this.valueLabel.ForeColor = Color.DarkRed;
                    return;
                }

                var start = 100;

                for (int i = 0; i < Memory.pingtimes.Length; i++)
                {
                    if (Memory.pingtimes[i] == 9999)
                        start -= 5;

                    else if (Memory.pingtimes[i] > Properties.Settings.Default.threshHigh)
                        start -= 3;

                    else if (Memory.pingtimes[i] > Properties.Settings.Default.threshMod)
                        start -= 2;

                    else if (Memory.pingtimes[i] > Properties.Settings.Default.threshLow)
                        start -= 1;
                }

                // Apply the arrow image
                if (start > this.progress_last_minute.Value)
                {
                    this.imgUpDown.Image = Properties.Resources.arrow_up;

                    if (!this.imgUpDown.Visible)
                        this.imgUpDown.Show();
                }

                else if (start < this.progress_last_minute.Value)
                {
                    this.imgUpDown.Image = Properties.Resources.arrow_down;

                    if (!this.imgUpDown.Visible)
                        this.imgUpDown.Show();

                }

                else
                    this.imgUpDown.Hide();

                this.progress_last_minute.Value = start;
                this.valueLabel.Text = start + "%";

                if (start < 50)
                    this.valueLabel.ForeColor = Color.Red;

                else if (start < 75)
                    this.valueLabel.ForeColor = Color.Orange;

                else
                    this.valueLabel.ForeColor = Color.Green;
            }
        }

        public void increaseCounter(int what, int amount)
        {
            if (what == 1)
            {
                var count = this.progress_last_minute.Value;

                if ((count + amount) > 100)
                {
                    this.progress_last_minute.Value = 100;
                    this.minute_percent.Text = "100%";
                }

                else
                {
                    count += amount;
                    this.progress_last_minute.Value = count;
                    this.minute_percent.Text = count + "%";
                }
            }
        }

        private void stopPinger_Click(object sender, EventArgs e)
        {

        }

        private void startSetupScreen(object sender, EventArgs e)
        {

            Form settings = new Admin();
            settings.ShowDialog();
        }

        private void openWebsite(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://software.3rad.ca/netwatch/");
        }
    }
}
