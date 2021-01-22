/* NetWatch by Ray Lynk
 * 
 * File:    Memory.cs
 * Purpose: Ping storage container
 * Version: 1.0.2.0
 * Author:  Ray Lynk
 * Email:   lynk@ngdevel.com
 * Website: http://netwatch.ngdevel.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetWatch_by_NGDevel.com
{
    class Memory
    {
        /* Currently used */
        public static int[] pingtimes = new int[PingCheck.MAXRECORDS];
        public static int pingIndex = 0;
      

        public static int failstreak = 0;
        public static int winstreak = 0;
        public static bool networkup = true;

        public static int lastmin_ping = 0;
        public static int lastmin_responses = 0;
        public static int lastmin_timeouts = 0;
        public static int lastmin_nextReset = 0;
        public static int lastmin_rating = 0;
    }
}
