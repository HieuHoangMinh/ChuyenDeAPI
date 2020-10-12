using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Interfaces;
using DAL;
using DAL.Helper;
using DAL.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.SqlServer.Server;

namespace API
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
            services.AddCors(options => {
                options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.AddControllers();
            services.AddTransient < IBrands, Brands > ();
            services.AddTransient<IBrandss, Brandss>();
            services.AddTransient<ICredentitalss, Credentitalss>();
            services.AddTransient<ICredentitals, Credentitals>();
            services.AddTransient<IFeedbackss, Feedbackss>();
            services.AddTransient<IFeedbacks, Feedbacks>();
            services.AddTransient<IFooterss, Footerss>();
            services.AddTransient<IFooters, Footers>();
            services.AddTransient<IMenuss, Menuss>();
            services.AddTransient<IMenus, Menus>();
            services.AddTransient<IMenuTypess, MenuTypess>();
            services.AddTransient<IMenuTypes, MenuTypes>();
            services.AddTransient<IOrderss, Orderss>();
            services.AddTransient<IOrders, Orders>();
            services.AddTransient<IDatabaseHelper, DatabaseHelper>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseApiMiddleware();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("AllowAll");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseHttpsRedirection();
        }
    }
}
