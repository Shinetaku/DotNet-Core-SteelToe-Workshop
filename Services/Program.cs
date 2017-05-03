using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace FortuneTeller.Services
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var config = new ConfigurationBuilder()
				.AddCommandLine(args)//so the app will get the port # for web server from envi var
				.Build();

			var host = new WebHostBuilder()
				.UseSetting("applicationName", "fortune-teller")//the app name reference
				.CaptureStartupErrors(true)//display an error page, if errors happen durning startup
				.UseContentRoot(Directory.GetCurrentDirectory())//folder where the application assembly resides
				.UseSetting("detailedErrors", "true")//the app will display details of startup
				.UseEnvironment("Development")//Development|Staging|Production|<ASPNETCORE_ENVIRONMENT envi var>
				//.UseUrls("http://*:5000;http://localhost:5001;https://hostname:5002")
				//.UseWebRoot("wwwroot")

				.UseConfiguration(config)//include the above configurations
				.UseKestrel()//to set up the web server
				.UseIISIntegration()//to set up the hist proxy to access web server
				.UseStartup<Startup>()//specify how to start the app
				.Build();

			host.Run();//starts the web app and blocks the calling thread until the host is shutdown
		}
	}
}
