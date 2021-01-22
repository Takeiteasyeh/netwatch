using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace NetWatch_by_NGDevel.com
{
    static class Program
    {
        public static LogView logView;
        public static string pingBuffer;
        public static Status status;
        public static bool updateLog = true;
        public static Monitor monitor;
        public static Thread t;

        /* Define Regex requirements */
        public static string validReply = @"^Reply from (\S+): bytes=(\d{1,3}) time=(\d{1,5})ms TTL=(\d+)$";
       // public static string validReply = @"/^Reply from (\w+): bytes=(\d{1,3}) time=(\d{1,5}) TTL=(\d+)$/";
        public static string timeout = "^Request timed out.$";
        //Reply from 192.168.0.101: Destination host unreachable.

     //   public static 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            logView = new LogView();
            status = new Status();
            monitor = new Monitor();

            status.Show();

            t = new Thread(new ThreadStart(PingCheck.FindBestHost));
            t.Name = "Host Finder";
            t.IsBackground = true; //mark as true or app never really ends!!
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            Application.Run(monitor);


          //  Application.Run(monitor = new Monitor());
            

        }
    }
}
