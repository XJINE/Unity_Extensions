using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

public static class IPAddressEx
{
    public static List<IPAddress> GetLocalIPAddresses
        (AddressFamily addressFamily = AddressFamily.InterNetwork)
    {
        List<IPAddress> addresses = new List<IPAddress>();

        IPHostEntry ipentry = Dns.GetHostEntry(Dns.GetHostName());

        foreach (IPAddress address in ipentry.AddressList)
        {
            if (address.AddressFamily == addressFamily)
            {
                addresses.Add(address);
            }
        }

        return addresses;
    }

    public static IPAddress FindIPAddress
        (string hostname, AddressFamily addressFamily = AddressFamily.InterNetwork)
    {
        IPAddress[] addresses = Dns.GetHostAddresses(hostname);
        IPAddress   address   = null;

        for (var i = 0; i < addresses.Length; i++)
        {
            if (addresses[i].AddressFamily == addressFamily)
            {
                address = addresses[i];
                break;
            }
        }

        return address;
    }
}