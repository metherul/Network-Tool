using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network_Tools
{
    class ResolveDNS
    {
        public static IPAddress GetIP(string _hostAddress)
        {
            var hostAddress = _hostAddress;
            Debug.WriteLine(hostAddress);

            try
            {
                return IPAddress.Parse(hostAddress);
            }

            catch (SocketException)
            {
                return null;
            }

            catch
            {
                return Dns.GetHostAddresses(hostAddress)[0];
            }
        }
    }
}
