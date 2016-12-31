using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Network_Tools
{
    class ResolveDNS
    {
        public static IPAddress GetIP(string _hostAddress)
        {
            string hostAddress = _hostAddress;
            var address = Dns.GetHostAddresses(hostAddress)[0];

            return address;
        }
    }
}
