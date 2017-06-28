using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Rentler.Admin.Web
{
    public class Startup
    {
          // This method gets called by the runtime. Use this method to add services to the container.
          // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
          public IConfiguration Configuration;
          public Startup(IHostingEnvironment env)
          {
            var builder = new ConfigurationBuilder()
                     .SetBasePath(env.ContentRootPath)
                     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                     .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                     .AddEnvironmentVariables();
            Configuration = builder.Build();
          }

          public void ConfigureServices(IServiceCollection services)
          {
                  services.AddMvc();
          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
          {
                  loggerFactory.AddConsole();

                  if (env.IsDevelopment())
                  {
                      app.UseDeveloperExceptionPage();
                  }

                  var authserver = Configuration.GetSection("AppSettings:RentlerAuthServer").Value;
                  app.UseJwtBearerAuthentication(new JwtBearerOptions
                  {
                    Authority = authserver,
                    RequireHttpsMetadata = false,
                    Audience = "admin.rentler.com-core.api"

                    //Audience = authServer + "/resources"
                    //the URI of a resource a user wants to access, others use scope names could be use as an audience
                  });

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

                  app.ApplicationServices.GetService<IHttpContextAccessor>();
                  app.UseMvcWithDefaultRoute();
                  app.UseDefaultFiles();
                  app.UseStaticFiles();
          }
    }
}
