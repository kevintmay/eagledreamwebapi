using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using eagleDreamWebAPI.Entities;

namespace eagleDreamWebAPI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();

            services.AddControllersWithViews(); ;

            // Get the connection string from appsettings.json
            var Connection = Configuration.GetConnectionString("DefaultConnection");

            // Add the service using 
            services.AddDbContext<DatabaseContext>(options => options.UseSqlite(Connection));

            // Register Swagger
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to server generated Swagger
            app.UseSwagger();

            // Enable middleware to server swagger-ui
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eagleDream API V1");
                // Set Swagger UI to serve at the app's root
                c.RoutePrefix = string.Empty;
            });

            // Use Redirection
            app.UseHttpsRedirection();
            // Use Sattic Files
            app.UseStaticFiles();
            // Use Routing
            app.UseRouting();
            // At this time Use Authorization
            app.UseAuthorization();

            // Default Routing = Home/Index
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                (
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
