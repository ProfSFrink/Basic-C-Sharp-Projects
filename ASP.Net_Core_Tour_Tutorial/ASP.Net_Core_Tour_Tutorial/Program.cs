// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 12: ASP.NET CORE Tour Tutorial
// AUTHOR: Steven Partlow
// DATE: 15/03/2023

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_Tour_Tutorial
{

    public class Program
    {

        public static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();

        } // End MAIN

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();

                });

    } // END Program CLASS

} // End ASP.NET_Core_Tour_Tutorial NAMESPACE
