using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nancy;
using Nancy.ModelBinding;
using System.Net.Sockets;
using Nancy.Hosting.Self;

namespace httplistenertest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //var hostConfigs = new HostConfiguration
            //{
            //    UrlReservations = new UrlReservations() { CreateAutomatically = true }
            //};

            //Uri uri = new Uri("http://localhost:8080");
            //var host = new NancyHost(hostConfigs, uri);
            //host.Start();
        }

        private IDisposable dispose;

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    
}
