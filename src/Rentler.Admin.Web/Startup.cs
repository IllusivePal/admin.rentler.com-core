using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Serilog;
using Serilog.Configuration;
using System.IO;
using Rentler.Admin.Configuration;
using Rentler.Admin.DataAccess;
using Rentler.Admin.DataAccess.Entities;
using Rentler.Cache.Redis;

namespace Rentler.Admin.Web
{
    public class Startup
    {
          // This method gets called by the runtime. Use this method to add services to the container.
          // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
          public IConfiguration Configuration;
          public Startup(IHostingEnvironment env,ILoggerFactory loggerFactory)
          {
            var builder = new ConfigurationBuilder()
                     .SetBasePath(env.ContentRootPath)
                     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                     .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                     .AddEnvironmentVariables();
            Configuration = builder.Build();

            /* Logs - Trap and Records logs */

            var serilog = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.File(@"Rentler.Admin.Log.txt");
            
            if(env.IsDevelopment())
            {
                serilog.WriteTo.LiterateConsole(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message}{NewLine}{Exception}{NewLine}");

            }

            loggerFactory.WithFilter(new FilterLoggerSettings {
                { "IdentityServer",LogLevel.Debug},
                {"Microsoft", LogLevel.Information },
                {"System",LogLevel.Error }
                })
                .AddSerilog(serilog.CreateLogger());


           /* End */
          }

          public void ConfigureServices(IServiceCollection services)
          {
                  services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
                  services.Configure<RedisConfig>(Configuration.GetSection("RedisSettings"));
                  services.Configure<BlobImagesConfig>(Configuration.GetSection("BlobImagesSetting"));

                  services.AddSingleton(Configuration);
                  services.AddMvc().AddJsonOptions(jsonoptions => {
                    jsonoptions.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                  });
                  // DI to Register
                  RegisterDependencyInjection(services);
                  var GlobalClaimOnly = new string[] { "Global" };
                  var SuperClaimOnly = new string[] { "super" };
                  var GlobalServiceClaimOnly = new string[] { "Global", "Service" };
                  var GlblSrvceSalesClaimOnly = new string[] { "Global", "Service", "Sales" };
                  services.AddAuthorization(options => {
                      options.AddPolicy("GlobalClaim",policy => policy.RequireClaim("role",GlobalClaimOnly));
                      options.AddPolicy("SuperClaim", policy => policy.RequireClaim("role", SuperClaimOnly));
                      options.AddPolicy("GlobalServiceClaim", policy => policy.RequireClaim("role", GlobalServiceClaimOnly));
                      options.AddPolicy("GlblSrvceSalesClaim", policy => policy.RequireClaim("role", GlblSrvceSalesClaimOnly));
                  });

          }

          //This method contains Services for registration
          public void RegisterDependencyInjection(IServiceCollection service)
          {
                var connectionString = Configuration.GetConnectionString("ConnectionString");
                                  service.AddDbContext<RentlerEntities>(opt => opt.UseSqlServer(connectionString))
                                          .AddScoped<IEntityMapper, RentlerEntityMapper>();
                service.AddTransient<IUserAdapter, UserAdapter>();
                
          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
              {
                      JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
                      loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                      loggerFactory.AddDebug();
                      
                  
                      var authserver = Configuration.GetSection("AppSettings:RentlerAuthServer").Value;
                      app.UseJwtBearerAuthentication(new JwtBearerOptions
                      {
                        Authority = authserver,
                        RequireHttpsMetadata = false,
                        Audience = "admin.rentler.com-core.api"

                        //Audience = authServer + "/resources"
                        //the URI of a resource a user wants to access, others use scope names could be use as an audience
                      });

                      app.ApplicationServices.GetService<IHttpContextAccessor>();

                      app.Use(async (context, next) => {
                          await next();
                          if (context.Response.StatusCode == 404 &&
                             !Path.HasExtension(context.Request.Path.Value) &&
                             !context.Request.Path.Value.StartsWith("/api/"))
                          {
                              context.Request.Path = "/index.html";
                              await next();
                          }
                      });
                      app.UseDefaultFiles();
                      app.UseStaticFiles();
                      app.UseMvc();
              }
    }
}
