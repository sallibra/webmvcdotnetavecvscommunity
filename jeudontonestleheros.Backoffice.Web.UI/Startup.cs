using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Backoffice.Web.UI.Constraints;
using jeudontonestleheros.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace jeudontonestleheros.Backoffice.Web.UI
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                                      .SetBasePath(env.ContentRootPath)
                                      .AddJsonFile("appsettings.json",
                                                   optional: false,
                                                   reloadOnChange: true)
                                      .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAuthentication()
                    .AddFacebook(options =>
                    {
                        options.AppId = this.Configuration["Api:Facebook:AppId"];
                        options.AppSecret = this.Configuration["Api:Facebook:AppSecret"];
                    });

            string connectionString = this.Configuration.GetConnectionString("DefaultContext");

            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "edition-paragraphe",
                    template: "edition-paragraphe/{id}",
                    defaults: new { controller = "Paragraphe", action = "Edit" },
                    constraints: new { id = new LogConstraint() });
                        //constraints: new { id = @"\d+" }
                        

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
