using Microsoft.EntityFrameworkCore;
using MVC_01.Models;

namespace MVC_01
{
    public class Startup
    {
        public Startup(IConfiguration config) { Configuration = config; }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("dbConnection")));
            services.AddControllersWithViews(); 
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
