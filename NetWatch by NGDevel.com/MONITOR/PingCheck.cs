/* NetWatch by Ray Lynk
 * 
 * File:    PingCheck.cs
 * Purpose: Provides required ping functions and basic response processing.
 * Version: 2.0.2
 * Author:  Ray Lynk with exerpts from 3rd parties.
 * Email:   lynk@ngdevel.com
 * Website: http://netwatch.ngdevel.com
 */

using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.NetworkInformation;
    using System.Threading;
    using System.Net;
    using System.Media;

    namespace NetWatch_by_NGDevel.com
    {
        //public delegate void ValidPingReply(PingEvent args);  
        //public delegate void InvalidPingReply(PingEvent args);
        //public delegate void FailedPing(PingEvent args);
        //public delegate void Connected(PingEvent args);

        public enum EventType
        {
            REPLY           = 0x01,
            NOREPLY         = 0x02,
            FAILURE         = 0x04,
            CONNECTED       = 0x06,
            DISCONNECTED    = 0x08
        };

        public class PingEvent : EventArgs
        {
            protected readonly int[] _replies;
            protected readonly EventType _type;
            protected readonly string _message;
            protected readonly int _lastPing;
            protected readonly int _medianPing;
            protected readonly int _lowestPing;
            protected readonly int _highestPing;

            public int[] Replies { get { return _replies; } }
            public EventType Type { get { return _type; } }
            public string Message { get { return _message; } }
            public int LastPing { get { return _lastPing; } }
            public int MedianPing { get { return _medianPing; } }
            public int LowestPing { get { return _lowestPing; } }
            public int HighestPing { get { return _highestPing; } }

            public PingEvent(int[] replies, EventType type, string message = "None Provided")
            {
                this._replies = replies;
                this._type = type;
                this._message = message;

                // Cycle and create our required stats to store
                this._lowestPing = replies.Min();
                this._highestPing = replies.Max();
                int currentIndex = ((Memory.pingIndex - 1) == -1 ? 0 : (Memory.pingIndex - 1));
                this._lastPing = replies[currentIndex];
                this._medianPing = (int)Math.Round(((float)replies.Sum() / (float)replies.Length));

            }

        }

        class PingCheck
        {
            public const int MAXRECORDS = 20; // weighted averages
            /* These are the hosts we will try when running the pinnger */
            public static string[] PINGHOSTS = { "bbc.co.uk", "dawn.com", "google.com", "youtube.com" };

            public static string[] PINGIPS = { "0", "0", "0", "0" };
            public static int[] PINGTIMES = { 9999, 9999, 9999, 9999 };
            public static string[] DEFAULTS = { "google.com", "173.194.33.48" };

            /* The host we will be using once the service is pinging */
            private static string[] HOSTIP = { null, null };

            public static event EventHandler<PingEvent> PingReply;
            public static event EventHandler<PingEvent> PingNoReply;


            protected static void OnEvent(PingEvent pingevent)
            {
                EventHandler<PingEvent> handler = (EventHandler<PingEvent>)PingCheck.returnEventHandlerFor(pingevent.Type);

                if (handler != null)
                    handler(null, pingevent);

            }

            private static object returnEventHandlerFor(EventType type)
            {
                object handle = null;

                switch (type)
                {
                    case EventType.CONNECTED:
                        throw new NotImplementedException("Event PingCheck:CONNECTED is not implemented");
                    
                    case EventType.DISCONNECTED:
                        throw new NotImplementedException("Event PingCheck:CONNECTED is not implemented");

                    case EventType.FAILURE:
                        throw new NotImplementedException("Event PingCheck:CONNECTED is not implemented");

                    case EventType.NOREPLY:
                        handle = PingNoReply;
                        break;

                    case EventType.REPLY:
                        handle = PingReply;
                        break;

                    default:
                        throw new NotSupportedException("Event is not a known type");

                }

                return handle;

            }

            /*
             * Find the best host to use for the ping service
             */
            public static void FindBestHost()
            {
                // We calculated we need this many steps on a good day. On a bad day, just set to 100 at the end
                int steps = 30;
                int eachStep = (100 / steps);

                // Bring the status window to the front
                Program.status.bringFront();

                Program.status.updateActivity("Resolving hostnames...");
                
                /* Ensure the counter is set to 0 */
                Program.status.resetCounter();

                // Cycle through our list of hosts and resolve them to IP's
                for (int i = 0; i < PingCheck.PINGHOSTS.Length; i++)
                {
                    string ip = "0";
                    string host = PingCheck.PINGHOSTS[i].ToString();

                    Program.status.increaseCounter(eachStep);
                    

                    // Not using a try block here causes an exemption when resolving fails.
                    try
                    {
                        IPHostEntry hostInfo = Dns.GetHostEntry(host);
                        ip = hostInfo.AddressList[0].ToString();
						Program.status.updateActivity("Resolved: " + host + "to " + ip);
					}

                    catch (Exception e)
                    {
                        // Send a log of the error to the console.
                        Program.status.updateActivity("Unable to resolve " + host + " [" + e.Message + "]");
                        Program.status.increaseCounter(eachStep);

                        // Proceed to the next host.
                        continue;

                    }

                    PingCheck.PINGIPS[i] = ip;
                }

                // Our array for the 4 replies to check each host
                long[] replies = { 0, 0, 0, 0};

                /* Cycle the ip's of the resolved hosts */
                for (int i = 0; i < PingCheck.PINGIPS.Length; i++)
                {

                    string ip = PingCheck.PINGIPS[i].ToString();

                    // Unresolved host; Next.
                    if (ip == "0")
                    {
                        Program.status.increaseCounter(eachStep);
                        continue;
                    }
                    
                    Program.status.increaseCounter(eachStep);
                    Program.status.updateActivity("Benchmarking: " + PingCheck.PINGHOSTS[i].ToString());

                    // Set some defaults. 9999 as lowest ping to ensure a result change.
                    long lowest = 9999;
                    long current;

                    // Ping the host 5 times and store the results in an array.
                    for (int c = 0; c < 5; c++)
                    {
                        
                        Program.status.increaseCounter(eachStep);
                        current = PingCheck.Ping(ip);

                        /* Only use fastest reply. */
                        if (current < lowest)
                            lowest = current;

                      //  Program.status.updateActivity("Benchmarking : " + PingCheck.PINGHOSTS[i].ToString() + " " + (c + 1) + "/5 replied " + current + "ms");
                        Thread.Sleep(40);
                    }

                    /* Set our lowest value to our array of replies from all hosts. */
                    replies[i] = lowest;
					Program.status.updateActivity("Bench Low: " + PingCheck.PINGHOSTS[i].ToString() + " -> " + lowest);

                }

                Program.status.increaseCounter(eachStep);
                Program.status.updateActivity("Determining best host...");

                long selected = 9999;

                // Cycle through the ping replies for each host and choose the lowest to use for the service.
                for (int g = 0; g < replies.Length; g++)
                {
                    Program.status.increaseCounter(eachStep);

                    // Current ping is lower than its predecessor (after googling I DID spell it right, shocking.)
                    if (replies[g] < selected)
                    {
                        // Set selected to current reply. Set ip string
                        selected = replies[g];
                        string ip = PingCheck.PINGIPS[g].ToString();

                        // Unresolved host. Skip as it doesn't have valid values anyways
                        if (ip == "0")
                            continue;

                        // Grap the host and ip and store to the using service.
                        PingCheck.HOSTIP[0] = PingCheck.PINGHOSTS[g].ToString();
                        PingCheck.HOSTIP[1] = ip;
                    }
                }

                // No valid results. Default to presets
                if (PingCheck.HOSTIP[1] == null)
                {
                    Program.status.updateActivity("No reply from test hosts-- using default.");
                    PingCheck.HOSTIP[0] = PingCheck.DEFAULTS[0];
                    PingCheck.HOSTIP[1] = PingCheck.DEFAULTS[1];
                }

                Program.status.increaseCounter(100);

                // Open the Monitor form if not already
                Program.monitor.openWindow();
            
                // Update Activity, set host string to our form display
                Program.status.updateActivity("Using Best Reply: " + PingCheck.HOSTIP[0] + "[" + PingCheck.HOSTIP[1] + "]");
                Program.monitor.setHostString(PingCheck.HOSTIP[0]);

                // Give the thread a second so the user knows whats going on
                Thread.Sleep(2500);

                // Hide this window, start the ping monitor, and end the curent thread
                Program.status.hideWindow();
                Program.monitor.start();
                Program.t.Abort();   
        }

        /* Start an individual ping process to an IP. Returns the time in long format.
         * 
         * @param string <ip>
         * @return long
         */
        public static long Ping(string ip)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "yarknylyarknylyarknyl2011raylynk";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 3000;

            // Attempt to send the ping
            PingReply reply = pingSender.Send(ip, timeout, buffer, options);

            // Check if we've had a successfull reply.
            if (reply.Status == IPStatus.Success)
            {
                Program.logView.addToLog("Reply from " + reply.Address.ToString() + ": bytes=" + reply.Buffer.Length + " time=" + reply.RoundtripTime + "ms");
 
                return reply.RoundtripTime;
            }

            /* no reply */
            Program.logView.addToLog("Benchmark: No response from " + ip);

            // We return 9999 to maintain a numerical value, but not one thats going to be chosen.
            return (long)9999;
        }

        /* Starts the ping loop on the registered host.
         * 
         * WARNING: This function contains an infinity loop. Ensure you know
         * what you are doing before you call it.
         */
        public static void Start()
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "yarknylyarknylyarknyl2011raylynk";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 3000;

            //------------------------------
            // Note: Entering Infinity loop.
            //------------------------------
            while (true)
            {
                // We dont want to flood our host servers. Wait 1 second between ping responses.
                Thread.Sleep(1000);

                // Ping?
				bool success = true;
				PingReply reply = null;

				try
				{
					reply = pingSender.Send(PingCheck.HOSTIP[1], timeout, buffer, options);
				}

				catch (Exception)
				{
					Program.logView.addToLog("PING: transmit failed. General failure.");
					success = false;
				}

				finally
				{
					if (success)
					{
						// Pong! (mIRC users will understand)
						if (reply.Status == IPStatus.Success)
						{
							Program.logView.addToLog("Reply from " + reply.Address.ToString() + ": bytes=" + reply.Buffer.Length + " time=" + reply.RoundtripTime + "ms");

							// Add this value to our ping responces over the last minute. Increase response count.
							Memory.lastmin_ping += Convert.ToInt32(reply.RoundtripTime);
							Memory.lastmin_responses++;

							// Reset failstreak to 0 and start the network up count(up)down.
							Memory.failstreak = 0;
							Memory.winstreak++;

							/* If we are recovering from ping failures and sound settings are on, play a notification */
							if ((Memory.winstreak < 10) && (Properties.Settings.Default.notifyLow))
							{
								SoundPlayer notify = new SoundPlayer(global::NetWatch_by_NGDevel.com.Properties.Resources.notify2);
								notify.Play();
							}

							/* If we had 7 successfull pings after a fail streak, set network up and try to play a sound */
							if ((Memory.winstreak == 7) && (!Memory.networkup))
							{
								Memory.networkup = true;

								/* Check if settings allow */
								if (Properties.Settings.Default.notifyOnConnect)
								{
									SoundPlayer connected = new SoundPlayer(global::NetWatch_by_NGDevel.com.Properties.Resources.connected);
									connected.Play();
								}
							}

							// Get our current location on the ping reply stack
							int index = Memory.pingIndex;

							// We only retain MAXRECORDS records; Reset back.
							if (index == MAXRECORDS)
							{
								index = 0;
								Memory.pingIndex = 0;
							}

                            /* Send a event notification that we have a ping reply */
                            PingEvent e = new PingEvent(Memory.pingtimes, EventType.REPLY);
                            PingCheck.OnEvent(e);

							/* Check for high ping and play sound notification if allowed */
							if ((Properties.Settings.Default.notifyHigh) && (Convert.ToInt32(reply.RoundtripTime) > Properties.Settings.Default.threshHigh))
							{
								SoundPlayer highping = new SoundPlayer(global::NetWatch_by_NGDevel.com.Properties.Resources.nicebeep);
								highping.Play();
							}

							// Add our current result to our reply stack and increase the index
							Memory.pingtimes[index] = Convert.ToInt32(reply.RoundtripTime);
							Memory.pingIndex++;
						}


				/* Ping reply failed. Try and determine why and start the spiral */
						else
						{
							success = false;

							//  Find out why we didnt succeed to give the techy end-user more trouble shooting information
							switch (reply.Status)
							{
								case IPStatus.DestinationHostUnreachable:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Destination host unreachable]");
									break;

								case IPStatus.DestinationNetworkUnreachable:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Destination network unreachable]");
									break;

								case IPStatus.DestinationProhibited:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Access denied]");
									break;

								case IPStatus.DestinationUnreachable:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [<unknown> Not reachable]");
									break;

								case IPStatus.HardwareError:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Hardware error]");
									break;

								case IPStatus.TimedOut:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Request timed out]");
									break;

								case IPStatus.TimeExceeded:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [Time Exceeded]");
									break;

								default:
									Program.logView.addToLog("No reply from " + PingCheck.HOSTIP[0] + " [<unknown>]");
									break;
							}
						}
					}
					if (!success)
					{

						// Set success streak to 0, increase the down-ward spiral.
						Memory.winstreak = 0;
						Memory.failstreak++;

						// If this is a relatively new fail streak, try and play a sound.
						if ((Memory.failstreak < 10) && (Properties.Settings.Default.notifyDrop))
						{
							SoundPlayer notify = new SoundPlayer(global::NetWatch_by_NGDevel.com.Properties.Resources.notify);
							notify.Play();
						}

						// If this failstreak reaches down limit, set network down and try to play a sound.
						if ((Memory.failstreak == 5) && (Memory.networkup))
						{
							Memory.networkup = false;

							if (Properties.Settings.Default.notifyOnDisconnect)
							{
								SoundPlayer disconnected = new SoundPlayer(global::NetWatch_by_NGDevel.com.Properties.Resources.connection_lost);
								disconnected.Play();
							}
						}

						int index2 = Memory.pingIndex;

						// We only retain MAXRECORDS records. 
						if (index2 == MAXRECORDS)
						{
							index2 = 0;
							Memory.pingIndex = 0;
						}

						Memory.pingtimes[index2] = 9999;
					}

				}
				Program.monitor.updateMonitor();
				}

            } 
        }
    }
        
     

