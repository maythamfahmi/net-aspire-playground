using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("rediscache");

var appInsightsConnectionString = builder.Configuration["APPLICATIONSIGHTS_CONNECTION_STRING"];

var weatherApi = builder.AddProject<Projects.WeatherApp_Api>("weatherapi")
    .WithEnvironment("APPLICATIONSIGHTS_CONNECTION_STRING", appInsightsConnectionString);

builder.AddProject<Projects.WeatherApp_Web>("frontend")
    .WithReference(weatherApi)
    .WithReference(cache)
    .WithEnvironment("APPLICATIONSIGHTS_CONNECTION_STRING", appInsightsConnectionString);


builder.Build().Run();