using Commiserator.Models;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.Configure<CommiseratorOptions>(builder.Configuration.GetSection("Commiserator"));

var app = builder.Build();

var commiseratorOptions = app.Services.GetService<IOptions<CommiseratorOptions>>();

if (commiseratorOptions == null)
{
    throw new Exception("Expected to be able to extract options");
}

Console.WriteLine("Resolved options, got client key " + commiseratorOptions.Value.ClientKey);

app.MapGet("/", () => "Hello Darkness!");

app.Run();
