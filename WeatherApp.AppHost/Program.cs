using Aspire.Hosting;
using Microsoft.Extensions.Azure;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("rediscache");
var kv = builder.AddAzureKeyVault("kv");

var appInsightsConnectionString = builder.Configuration["APPLICATIONSIGHTS_CONNECTION_STRING"];

var weatherapi = builder.AddProject<Projects.WeatherApp_Api>("weatherapi")
    .WithReference(kv)
    .WithEnvironment("APPLICATIONSIGHTS_CONNECTION_STRING", appInsightsConnectionString);

builder.AddProject<Projects.WeatherApp_Web>("frontend")
    .WithReference(weatherapi)
    .WithReference(cache)
    .WithEnvironment("APPLICATIONSIGHTS_CONNECTION_STRING", appInsightsConnectionString);


builder.Build().Run();