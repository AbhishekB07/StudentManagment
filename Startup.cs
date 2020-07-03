
using DuckTaleSolutionTask.Models.Context;
using DuckTaleSolutionTask.Models.Interfaces;
using DuckTaleSolutionTask.Models.Repositories;
using DuckTaleSolutionTask.Models.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;


namespace DuckTaleSolutionTask
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<AppDbContext>(options =>
            {
                string ConnectionString = Configuration.GetSection("ConnectionString").Value;
                options.UseSqlServer(ConnectionString);
            });

            services.AddScoped<IStudentRepository, StudentRepository>();

            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(this.GetType().Assembly);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCookiePolicy();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "Add",
                  template: "{controller=Student}/{action=AddStudent}");


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Student}/{action=Index}/{id?}");
            });
        }
    }
}
