using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using System.Data.SQLite;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var provider = ConfigureServices();
            HomeDbContext homedbcontext =  provider.GetService<HomeDbContext>();


        }
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

         

            services.AddMvcCore().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(@"Data Source=C:\Data\SQLLites\Smart.Wasl.Homes.Appliances.db; Version = 3; New = True; Compress = True; ");

            services.AddDbContext<HomeDbContext>((options => options.UseSqlite(sqlite_conn)));
            return services.BuildServiceProvider();

        }
    }
   

}
