using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace Network_Tools
{
    class PingNetwork
    {
        public static PingData Send(string _ipAddress)
        {
            var ping = new Ping();

            try
            {
                var ipAddress = IPAddress.Parse(_ipAddress);
                var pingReply = ping.Send(ipAddress);
                var pingData = new PingData(pingReply.Status, pingReply.RoundtripTime, ipAddress);

                return pingData;
            }

            catch
            {
                var ipAddress = ResolveDNS.GetIP(_ipAddress);
                var pingReply = ping.Send(ipAddress);
                var pingData = new PingData(pingReply.Status, pingReply.RoundtripTime, ipAddress);

                return pingData;
            }
        }
    }

    public class PingData
    {
        public IPStatus IpStatus { get; set; }
        public long RoundtripTime { get; set; }
        public IPAddress IpAddress { get; set; }

        public PingData(IPStatus _ipStatus, long _roundTripTime, IPAddress _ipAddress)
        {
            IpStatus = _ipStatus;
            RoundtripTime = _roundTripTime;
            IpAddress = _ipAddress;
        }

    }
}
