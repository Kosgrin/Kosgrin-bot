﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Telegram_Bot
{
	public class Program
	{
		public static void Main(string[] args)
		{
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(config)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
            //CreateWebHostBuilder(args).Build().Run();
		}

		//public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
		//	WebHost.CreateDefaultBuilder(args)
		//		.UseStartup<Startup>();
	}
}
