using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace httplistenertest
{
    public class RoutingModule : NancyModule
    {
        public RoutingModule()
        {
            Get("/", _ => {

                return test();
            });
        }


        private string test()
        {
            return "http://192.168.101.170:8080/";
        }
    }
}
