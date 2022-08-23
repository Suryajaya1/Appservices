using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appservices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>

                //Azure config
                webBuilder.ConfigureAppConfiguration(config =>
                {

                    var settings = config.Build();
                    config.AddAzureAppConfiguration("Endpoint=https://apserazresource.azconfig.io;Id=V9m7-l0-s0:SB9sKJITLyh2HlDxGkOZ;Secret=pOamd9I09bmmx6H4K+tHRrHBQGzoSazLscwMN2w61I4=");
                })
                        .UseStartup<Startup>());
    }
}
