using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context , next) => {
            //    await context.Response.WriteAsync("Welcome in my website first midleware");
            //    await next();
            //} );

            //app.Use(async (context , next) => {
            //    await context.Response.WriteAsync("\nSecond midleware ");
            //    await next();
            //    await context.Response.WriteAsync("\nThird midleware ");
                
            //});

            //app.Use(async (context , next) => {
            //    await context.Response.WriteAsync("\nFourth midleware");
            //    await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    if ((bool) env.IsDevelopment)
                    {
                        await context.Response.WriteAsync("Hello in Dev");
                    }
                    else if ( (bool) env.IsProduction)
                    {
                        await context.Response.WriteAsync("Hello in Prod");
                    }else if (Convert.ToBoolean(env.IsStaging))
                    {
                        await context.Response.WriteAsync("Hello in Staging");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }
                    
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/House", async context =>
                {
                    
                    await context.Response.WriteAsync("\nHello House ...!");
                });
            });
        }
    }
}
