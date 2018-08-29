using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Profiles.Extensions;
namespace Smart.Wasl.Homes.Services.HomeAppliances
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            BuildWebHost(args)
                .MigrateDbContext<HomeAppliances.Data.HomeAppliancesContext>((context, services) =>
                {
                   // var db = services.GetService<HomeDbContext>();
                    //HomeDbContext.Seed(db);
                })
                .Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .UseApplicationInsights()
               .Build();
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    //WebHost.CreateDefaultBuilder(args)
        //    //    .UseStartup<Startup>();
        //    WebHost.CreateDefaultBuilder(args)
        //                .UseStartup<Startup>()
        //             //   .UseApplicationInsights()
        //                .Build();
    }
}
