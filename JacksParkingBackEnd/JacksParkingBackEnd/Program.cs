using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JacksParkingBackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //creates the application
            CreateHostBuilder(args).Build().Run();
            byte[] temp = Bitmapping.getR();
            Console.WriteLine("hello world");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
