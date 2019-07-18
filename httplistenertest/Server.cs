using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace httplistenertest
{
    public static class Server
    {
        public static void Start()
        {
            var hostConfigs = new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            Uri uri = new Uri("http://localhost:8080");
            var host = new NancyHost(hostConfigs, uri);
            host.Start();
        }
    }
}
