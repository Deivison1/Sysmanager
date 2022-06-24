using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Sysmanager.API.Admin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}