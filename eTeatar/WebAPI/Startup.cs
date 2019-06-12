using AutoMapper;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Repository;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using WebAPI.Security;
using WebAPI.Services;
using WebAPI.Services.Interfaces;

namespace WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
            {
                { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
            };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }
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

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); ;

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            // Add DbContext from Repository layer
            services.AddDbContext<eTeatarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Local")));

            // Add Web API services
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Teatar, TeatarSearchRequest, TeatarUpsertRequest, TeatarUpsertRequest>),
                typeof(TeatarService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Dvorana, DvoranaSearchRequest, DvoranaUpsertRequest, DvoranaUpsertRequest>),
                typeof(DvoranaService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Obavijest, ObavijestSearchRequest, ObavijestUpsertRequest, ObavijestUpsertRequest>),
                typeof(ObavijestService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Uloga, object, UlogaUpsertRequest, UlogaUpsertRequest>),
                typeof(CrudService<DataTransferObjects.Uloga, object, Models.Uloga, UlogaUpsertRequest, UlogaUpsertRequest>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.TipSjedista, object, TipSjedistaUpsertRequest, TipSjedistaUpsertRequest>),
                typeof(CrudService<DataTransferObjects.TipSjedista, object, Models.TipSjedista, TipSjedistaUpsertRequest, TipSjedistaUpsertRequest>));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.Drzava, object>),
                typeof(BaseService<DataTransferObjects.Drzava, object, Models.Drzava>));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.Grad, GradSearchRequest>),
                typeof(BaseService<DataTransferObjects.Grad, GradSearchRequest, Models.Grad>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Termin, object, TerminUpsertRequest, TerminUpsertRequest>),
                typeof(CrudService<DataTransferObjects.Termin, object, Models.Termin, TerminUpsertRequest, TerminUpsertRequest>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Narudzba, object, NarudzbaInsertRequest, object>),
                typeof(NarudzbaService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Predstava, PredstavaSearchRequest, PredstavaUpsertRequest, PredstavaUpsertRequest>),
                typeof(CrudService<DataTransferObjects.Predstava, PredstavaSearchRequest, Models.Predstava, PredstavaUpsertRequest, PredstavaUpsertRequest>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest>),
                typeof(CrudService<DataTransferObjects.DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest, Models.DvoranaTipSjedista, DvoranaTipSjedistaUpsertRequest, DvoranaTipSjedistaUpsertRequest>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Glumac, GlumacSearchRequest, GlumacUpsertRequest, GlumacUpsertRequest>),
                typeof(CrudService<DataTransferObjects.Glumac, GlumacSearchRequest, Models.Glumac, GlumacUpsertRequest, GlumacUpsertRequest>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Termin, TerminSearchRequest, TerminUpsertRequest, TerminUpsertRequest>),
                typeof(TerminService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Komentar, object, KomentarInsertRequest, object>),
              typeof(KomentarService));
            services.AddScoped(typeof(IKorisnickiNalogService), typeof(KorisnickiNalogService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Kupac, object, KupacKorisnickiNalogUpsertRequest, KupacKorisnickiNalogUpsertRequest>),
              typeof(KupacService));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.Administrator, object, AdministratorKorisnickiNalogUpsertRequest, AdministratorKorisnickiNalogUpsertRequest>),
              typeof(AdministratorService));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.KorisnickaUloga, KorisnickaUlogaSearchRequest>),
              typeof(BaseService<DataTransferObjects.KorisnickaUloga, KorisnickaUlogaSearchRequest, KorisnickaUloga>));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.Spol, object>),
             typeof(BaseService<DataTransferObjects.Spol, object, Spol>));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.TipKorisnika, TipKorisnikaSearchRequest>),
              typeof(BaseService<DataTransferObjects.TipKorisnika, TipKorisnikaSearchRequest, TipKorisnika>));
            services.AddScoped(typeof(IBaseService<DataTransferObjects.Zanr, ZanrSearchRequest>),
                typeof(BaseService<DataTransferObjects.Zanr, ZanrSearchRequest, Models.Zanr>));
            services.AddScoped(typeof(ICrudService<DataTransferObjects.PredstavaZanr, object, DataTransferObjects.Requests.PredstavaZanrUpsertRequest, DataTransferObjects.Requests.PredstavaZanrUpsertRequest>),
                typeof(CrudService<DataTransferObjects.PredstavaZanr, object, Models.PredstavaZanr, DataTransferObjects.Requests.PredstavaZanrUpsertRequest, DataTransferObjects.Requests.PredstavaZanrUpsertRequest>));
            // Add Repository
            services.AddScoped(typeof(IRepository<Teatar, TeatarSearchRequest>), typeof(TeatarRepository));
            services.AddScoped(typeof(IRepository<Dvorana, DvoranaSearchRequest>), typeof(DvoranaRepository));
            services.AddScoped(typeof(IRepository<Obavijest, ObavijestSearchRequest>), typeof(ObavijestRepository));
            services.AddScoped(typeof(IRepository<Predstava, PredstavaSearchRequest>), typeof(PredstavaRepository));
            services.AddScoped(typeof(IRepository<Uloga, object>), typeof(Repository<Uloga, object>));
            services.AddScoped(typeof(IRepository<Narudzba, object>), typeof(Repository<Narudzba, object>));
            services.AddScoped(typeof(IRepository<TipSjedista, object>), typeof(Repository<TipSjedista, object>));
            services.AddScoped(typeof(IRepository<Drzava, object>), typeof(Repository<Drzava, object>));
            services.AddScoped(typeof(IRepository<Grad, GradSearchRequest>), typeof(GradRepository));
            services.AddScoped(typeof(IRepository<Termin, object>), typeof(Repository<Termin, object>));
            services.AddScoped(typeof(IRepository<DvoranaTipSjedista, DvoranaTipSjedistaSearchRequest>), typeof(DvoranaTipSjedistaRepository));
            services.AddScoped(typeof(IRepository<Glumac, GlumacSearchRequest>), typeof(GlumacRepository));
            services.AddScoped(typeof(IRepository<Termin, TerminSearchRequest>), typeof(TerminRepository));
            services.AddScoped(typeof(IRepository<Komentar, object>), typeof(Repository<Komentar, object>));
            services.AddScoped(typeof(IKorisnickiNalogRepository), typeof(KorisnickiNalogRepository));
            services.AddScoped(typeof(IRepository<Kupac, object>), typeof(KupacRepository));
            services.AddScoped(typeof(IRepository<Administrator, object>), typeof(Repository<Administrator, object>));
            services.AddScoped(typeof(IRepository<KorisnickaUloga, KorisnickaUlogaSearchRequest>), typeof(KorisnickeUlogeRepository));
            services.AddScoped(typeof(IRepository<TipKorisnika, TipKorisnikaSearchRequest>), typeof(TipKorisnikaRepository));
            services.AddScoped(typeof(IRepository<Zanr, ZanrSearchRequest>), typeof(ZanrRepository));
            services.AddScoped(typeof(IRepository<PredstavaZanr, object>), typeof(Repository<PredstavaZanr,object>));
            services.AddScoped(typeof(IRepository<Spol, object>), typeof(Repository<Spol,object>));

            // Register the Swagger generator, def 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "eTeatarAPI", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
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
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
