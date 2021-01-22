/* NetWatch by Ray Lynk
 * 
 * File:    Status.cs
 * Purpose: Status progress notification screen.
 * Version: 2.0.2
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
    public partial class Status : Form
    {
        public delegate void dString(string message);
        public delegate void dInt(int numeric);
        public delegate void dVoid();

        public Status()
        {
            InitializeComponent();
        }

        public void bringFront()
        {
            if (this.InvokeRequired)
                this.Invoke((dVoid)this.bringFront);

            else
                this.BringToFront();
        }

        public void updateCurrentValue(int numeric)
        {
            if (this.InvokeRequired)
                this.Invoke((dInt)this.updateCurrentValue, numeric);

            else
            {
                this.currentValue.Text = numeric + "%";
            }
        }
        public void updateActivity(string activity)
        {
            if (this.InvokeRequired)
                this.Invoke((dString)this.updateActivity, activity);

            else
            {
                this.statusActionString.Text = activity;
                Program.logView.addToLog(activity);
            }
        }

        public void hideWindow()
        {
            if (this.InvokeRequired)
                this.Invoke((dVoid)this.hideWindow);

            else
                this.Hide();
        }

        public void resetCounter()
        {
            if (this.InvokeRequired)
                this.Invoke((dVoid)this.resetCounter);

            else
            {
                this.statusBar.Value = 0;
                return;
            }
        }

        public void increaseCounter(int amount)
        {
            if (this.InvokeRequired)
                this.Invoke((dInt)this.increaseCounter, amount);

            else
            {
                int count = this.statusBar.Value;

                if ((count + amount) > 100)
                {
                    this.statusBar.Value = 100;
                    this.updateCurrentValue(100);
                }

                else
                {
                    count += amount;
                    this.statusBar.Value = count;
                    this.updateCurrentValue(count);
                }
            }
        }
    }
    }


