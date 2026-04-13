using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Platform;
var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<MessageOptions>(Options =>
{
    Options.CityName = "Albany";
});
var app = builder.Build();
app.UseMiddleware<LocationMiddleware>();
app.MapGet("/", () => "Hello World!");
app.Run();