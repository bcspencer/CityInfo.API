using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using NLog;
using NLog.Common;

namespace CityInfo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InternalLogger.LogToConsole = true;

            // enable internal logging to a file
            InternalLogger.LogFile = "d:\\log.txt";

            // enable internal logging to a custom TextWriter
            InternalLogger.LogWriter = new StringWriter(); //e.g. TextWriter writer = File.CreateText("C:\\perl.txt")

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run(); 
        }
    }
}
