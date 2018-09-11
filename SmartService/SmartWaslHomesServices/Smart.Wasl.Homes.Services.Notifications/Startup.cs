using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Newtonsoft.Json;
using Smart.Wasl.Homes.Services.Notifications.Services;
using Smart.Wasl.Homes.Services.Notifications.Data;

namespace Smart.Wasl.Homes.Services.Notifications
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {

            var builder = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                        .AddEnvironmentVariables();
            Configuration = builder.Build();

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //if (!string.IsNullOrEmpty(Configuration["k8sname"]))
            //{
            //   services.EnableKubernetes();
            //}

           
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<NotificationInfoService>();
            services.AddTransient<NotificationsManageService>();
            services.AddTransient<NotificationsActionService>();
            services.Configure<AppSettings>(Configuration);
            services.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "Smart Wasl Home - Home Appliance HTTP API",
                    Version = "v1",
                    Description = "The Home Appliance Microservice HTTP API. This is a Data-Driven/CRUD microservice sample",
                    TermsOfService = "Terms Of Service"
                });
            });
            services.AddDbContext<NotificationsDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
          );


            return services.BuildServiceProvider();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider,
            ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            //loggerFactory.AddAzureWebAppDiagnostics();
            //loggerFactory.AddApplicationInsights(app.ApplicationServices, LogLevel.Trace);

            var pbase = Configuration["PATH_BASE"];
            if (!string.IsNullOrEmpty(pbase))
            {
                app.UsePathBase(pbase);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
            app.UseStaticFiles();
            //app.UseByPassAuth();
            app.UseAuthentication();
            app.UseCors("allowall");



            app.UseSwagger()
           .UseSwaggerUI(c =>
           {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
           });
            //app.UseSwaggerUI(c =>
            //{
            //    var b2cConfig = Configuration.GetSection("b2c");
            //    var path = string.IsNullOrEmpty(pbase) || pbase == "/" ? "/" : $"{pbase}/";
            //   // c.InjectOnCompleteJavaScript($"{path}swagger-ui-b2c.js");
            //    c.SwaggerEndpoint($"{path}swagger/v1/swagger.json", "Hotels Api");
            //    c.ConfigureOAuth2(b2cConfig["ClientId"], "y", "z", "z", "",
            //        new
            //        {
            //            p = "B2C_1_SignUpInPolicy",
            //            prompt = "login",
            //            nonce = "defaultNonce"
            //        });
            //});

            app.UseMvc();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(

            //        name: "goto_one",

            //        template: "{controller}/{action}/{objectname}/{id}",
            //        defaults: new { controller = "HomeAppliance", action = "Info" });

            //    routes.MapRoute(
            //       name: "default",
            //       template: "{controller=HomeAppliance}/{action=Index}/{id?}");


            //});
        }
    }
}
