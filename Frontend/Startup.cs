using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using persistencia;
using Microsoft.EntityFrameworkCore;

namespace Frontend
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
            services.AddRazorPages();
            services.AddScoped<IRepositorioPersona,RepositorioPersona>();
            services.AddScoped<IRepositorioCliente,RepositorioCliente>();
            services.AddScoped<IRepositorioTecnico,RepositorioTecnico>();

            services.AddScoped<IRepositorioVehiculo,RepositorioVehiculo>();
            services.AddScoped<IRepositorioAuto,RepositorioAuto>();
            services.AddScoped<IRepositorioCamioneta,RepositorioCamioneta>();

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();  //punto 12 Adicionado taller laboratorio 1 semana 7

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();  //verificado taller laboratorio 1 semana 7

            app.UseRouting();

            app.UseAuthentication(); //punto 11 Adicionado taller laboratorio 1 semana 7
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
