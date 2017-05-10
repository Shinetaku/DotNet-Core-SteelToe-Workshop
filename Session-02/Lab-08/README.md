[appmanager-service-registry]: img/appmanager-service-registry.png " "

# Lab 08 - Refactor DotNet Core for Service Discovery

## Add SteelToe Dependcies amd Spring Cloud Discovery
1. Within the Fortune Teller service app, go to the /Services/Startup.cs file and update the following:
[Add the dependencies]
```
using Steeltoe.Extensions.Configuration;
using Steeltoe.CloudFoundry.Connector.MySql.EFCore;
using Steeltoe.Discovery.Client;
```
[Edit the Startup method]
```
var builder = new ConfigurationBuilder()
					.SetBasePath(env.ContentRootPath)
					.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
					.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
-->			.AddConfigServer(env) //use the Spring Cloud Config Server for custom MySql config
					//.AddCloudFoundry() // Add `VCAP_` configuration info
					.AddEnvironmentVariables();
```
[Add the following line to ConfigureServices method]
```
services.AddDiscoveryClient(Configuration);
```
[Add the following line to the Configure method]
```
app.UseDiscoveryClient();
```

## Update Manifest With Spring Cloud Services
1. Within the Fortune Teller service app, go to the manifest.yml file and update the following:
[Add Spring Cloud services]
```
  services:
    - mysql-100mb
    - service-registry
    - config-serverc
```

## Consume Discovered Service
1. XXXX

## View Changes
1. XXXX


___

___
| **[Prev Lab](../Lab-07/README.md)** |_______________________________________________________________________________| **[Finished](../../README.md)** |