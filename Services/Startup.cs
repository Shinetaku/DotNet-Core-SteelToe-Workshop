using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

//For Logging
using Microsoft.Extensions.Logging;

//For MySql
using MySQL.Data.EntityFrameworkCore.Extensions;

//For SteelToe
using Steeltoe.Extensions.Configuration;
using Steeltoe.CloudFoundry.Connector.MySql.EFCore;

namespace FortuneTeller.Services
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
					.SetBasePath(env.ContentRootPath)
					.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
					.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
					//.AddConfigServer(env) //use the Spring Cloud Config Server for custom MySql config
					.AddCloudFoundry() // Add `VCAP_` configuration info
					.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//Using Internal Datastore
			//services.AddDbContext<FortuneTellerContext>(opt => opt.UseInMemoryDatabase());
			
			//Using MySql Datastore
			/*
			string connString = "";
			try{
				dynamic vcap = JObject.Parse(Environment.GetEnvironmentVariable("VCAP_SERVICES"));
				connString = String.Format("Server={0};port={1};Database={2};uid={3};pwd={4};",
					vcap["p-mysql"][0].credentials.hostname,
					vcap["p-mysql"][0].credentials.port,
					vcap["p-mysql"][0].credentials.name,
					vcap["p-mysql"][0].credentials.username,
					vcap["p-mysql"][0].credentials.password);
			}catch(Exception ex){
				Console.Error.WriteLine("Error retrieving database connection string from environment variables");
				Console.Error.WriteLine(ex);
				Environment.Exit(1);
			}
			
			services.AddDbContext<FortuneTellerContext>(opt => opt.UseMySQL(connString));
			*/
			
			//Using SteelToe for MySql
			services.AddDbContext<FortuneTellerContext>(options => options.UseMySql(Configuration));
			//services.AddDiscoveryClient(ServerConfig.Configuration);

			services.AddMvc();
			services.AddScoped<IFortuneTeller, FortuneTeller>();
			services.AddCors();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, FortuneTellerContext fortuneContext)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
			
			try{
				fortuneContext.Database.Migrate();
			}catch(Exception){
				fortuneContext.Database.ExecuteSqlCommand("CREATE TABLE `__EFMigrationsHistory` ( `MigrationId` nvarchar(150) NOT NULL, `ProductVersion` nvarchar(32) NOT NULL, PRIMARY KEY (`MigrationId`) );");
				fortuneContext.Database.Migrate();
			}

			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseMvc();
		}
	}
}
