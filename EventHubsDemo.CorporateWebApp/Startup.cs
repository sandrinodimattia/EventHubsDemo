using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EventHubsDemo.Shared.Contracts;
using Microsoft.Owin;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventHubsDemo.CorporateWebApp.Startup))]
namespace EventHubsDemo.CorporateWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Trace.WriteLine("Starting Web Application (OWIN)");

            ConfigureAuth(app);
        }
    }
}
