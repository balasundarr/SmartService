using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;
using Smart.Wasl.Homes.Services.HomeAppliances.Data;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Contracts;
using Smart.Wasl.Homes.Services.HomeAppliances.Data.Repositries;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain.Interfaces;
using Smart.Wasl.Homes.Services.HomeAppliances.Services.Interface;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerUI;
using Smart.Wasl.Homes.Services.HomeAppliances.Settings;
using Smart.Wasl.Homes.Services.HomeAppliances.Services;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
namespace Smart.Wasl.Homes.Services.HomeAppliances
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

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //if (!string.IsNullOrEmpty(Configuration["k8sname"]))
            //{
            //   services.EnableKubernetes();
            //}

            services.AddMvc();
           
            services.AddTransient<HomeApplianceActionService>();
            services.AddTransient<HomeApplianceManageService>();
            services.AddTransient<HomeApplianceInfoService>();
          
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

            //services.ConfigureSwaggerGen(swaggerGen =>
            //{
            //    var b2cConfig = Configuration.GetSection("b2c");
            //    var authority = string.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0", b2cConfig["Tenant"]);
            //    swaggerGen.AddSecurityDefinition("Swagger", new OAuth2Scheme
            //    {
            //        AuthorizationUrl = authority + "/authorize",
            //        Flow = "implicit",
            //        TokenUrl = authority + "/connect/token",
            //        Scopes = new Dictionary<string, string>
            //        {
            //            { "openid","User offline" },
            //        }
            //    });

            //});

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtOpt =>
            //{
            //    var b2cConfig = Configuration.GetSection("b2c");
            //    jwtOpt.Authority = string.Format("https://login.microsoftonline.com/tfp/{0}/{1}/v2.0/", b2cConfig["tenant"], b2cConfig["policy"]);

            //    jwtOpt.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidAudiences = b2cConfig["audiences"].Split(',')
            //    };
            //    jwtOpt.Events = new JwtBearerEvents();
            //});


            services.AddDbContext<HomeAppliancesContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            
            return services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider,
            ILoggerFactory loggerFactory)
        {
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
                
           
        // public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();
        //}

        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }
        //    app.UseMvc();
        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Mvc is not found Anything!");
        //    });
        //}


    }
}
