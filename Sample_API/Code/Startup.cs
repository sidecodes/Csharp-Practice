using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Payroll.Services;

namespace Payroll
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /*
         * We will take advantage of this built-in container to register our DataService. 
         * To do this, we need to write the code to register our service in the ConfigureServices (IServiceCollection services) method of the Startup class. 
         * The IServiceCollection interface here represents a list of dependencies  
        */
        public void ConfigureServices(IServiceCollection services)
        {
         /*
          * Note the usage of the AddTransient method in the code snippet above. 
          * There are three ways to register dependencies: AddTransient, AddScoped and AddSingleton.
          * These methods correspond to Transient, Scoped and Singleton lifetimes of the dependencies.
          * In this example, we are calling the AddTransient method when registering the service with the container.
          * In doing so, the component will be re - created for every request; that is, it would represent a stateless service.
         */
            services.AddTransient<IDataService, DataService>();
            services.AddMvc().SetCompatibilityVersion
                (CompatibilityVersion.Version_3_0);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
