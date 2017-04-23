using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace DayTraderDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddEnvironmentVariables("")
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)              
                .AddEnvironmentVariables().Build();
            

            var url = config["ASPNETCORE_URLS"] ?? "http://*:8080";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls(url)
                .Build();

            host.Run();

        }
      
    }
}
