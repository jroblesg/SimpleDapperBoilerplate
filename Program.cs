using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new HostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseKestrel(serverOptions => { })
                .UseIISIntegration()
                .UseStartup<Startup>();
            })
            .Build();

            host.Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                webBuilder.UseIISIntegration();
                webBuilder.ConfigureKestrel(serverOptions => {})
                .UseStartup<Startup>();
            });
    }
}
