using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data;
using webProjects.Data.Interfaces;
using webProjects.Data.Mocks;
using webProjects.Data.Repository;

namespace webProjects {
    public class Startup {
        private IConfigurationRoot _confString;

        //IHostingEnvironment is obsolete, then we use IWebHostEnvironment
        public Startup(IWebHostEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services) {
            //For UseSqlServer we need Microsoft.EntityFrameworkCore.SqlServer
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}