using AutoMapper;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Swashbuckle.AspNetCore.Swagger;
using Repository;
using WebAPI.Services;
using WebAPI.Services.Interfaces;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the contastringer.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Automapper service
            services.AddAutoMapper();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Add DbContext from Repository layer
            services.AddDbContext<eTeatarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Local")));

            // Add Web API services
              services
                .AddScoped<ICrudService<DataTransferObjects.Teatar, TeatarSearchRequest, TeatarUpsertRequest,
                    TeatarUpsertRequest>, TeatarService>();
            
            // Add Repository
            services
                .AddScoped<IRepository<Models.Teatar, TeatarSearchRequest>,
                    TeatarRepository>();
            
            // Register the Swagger generator, defstringstringg 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "eTeatarAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipelstringe.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpostring.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifystringg the Swagger JSON endpostring.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eTeatar API V1");
            });
            app.UseMvc();
        }
    }
}
