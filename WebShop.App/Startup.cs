using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebShop.Core.Interfaces;
using WebShop.Core.Services;
using WebShop.Data.Data;
using WebShop.Data.InMemory.Data;
using WebShop.Data.InMemory.Repository;
using WebShop.Data.Manager.Factory;
using WebShop.Data.Repository;

namespace WebShop.App
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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllersWithViews();

            //DataBase instance
            services.AddDbContext<WebShopContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("WebShop")));
            services.AddDbContext<InMemoryContext>(options => options.UseInMemoryDatabase(databaseName: "InMemory_DB"));

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IRepositoryFactory, RepositoryFactory>();

            services.AddScoped<ProductInMemoryRepository>();
            services.AddScoped<IProductRepository, ProductInMemoryRepository>(s => s.GetService<ProductInMemoryRepository>());

            services.AddScoped<ProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>(s => s.GetService<ProductRepository>());

            services.AddSingleton<SwichDBService, SwichDBService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
