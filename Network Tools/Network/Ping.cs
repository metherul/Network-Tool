using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Network_Tools
{
    class PingNetwork
    {
        public static PingData Send(string _ipAddress)
        {
            Debug.WriteLine(_ipAddress);

            var ping = new Ping();

            var ipAddress = ResolveDNS.GetIP(_ipAddress);

            if (ipAddress == null)
                return null;

            var pingReply = ping.Send(ipAddress, 500);
            var pingData = new PingData(pingReply.Status, pingReply.RoundtripTime, ipAddress);

            return pingData;
        }

        public static List<PingData> SendMultipleAsync(List<LabelData> _labels)
        {
            var labels = _labels;
            var pingDataList = new List<PingData>();

            var times = labels.AsParallel().WithDegreeOfParallelism(64)
                          .Select(h => new Ping().Send(h.addressLabel, 500));
            
            // Then, serialize back into the labels 
            foreach (var time in times)
            {
                var pingData = new PingData(time.Status, time.RoundtripTime, null);
                pingDataList.Add(pingData);
            }

            return pingDataList;
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
            IpAddress = _ipAddress;
            RoundtripTime = _roundTripTime;

        }

    }
}
