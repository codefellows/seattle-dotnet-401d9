using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSCohort9.Data;
using CMSCohort9.Models;
using CMSCohort9.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CMSCohort9
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public Startup()
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // register the database for non user related items
            services.AddDbContext<BlogDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BlogDefaultConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("UserDefaultConnection")));

            // Connect the User with the specific Database to store the information
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            options.AddPolicy("AdminOnly", policy => policy.RequireRole(ApplicationRoles.Admin)));

            services.AddScoped<IEmailSender, EmailSender>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable the use of Authentication
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute() ;
                

            });

            RoleInitializer.SeedData(serviceProvider);
        }
    }
}
