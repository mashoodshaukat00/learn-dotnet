using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Exercise.Vue3Net5.WebApp
{
    using Exercise.EfCore.Models;
    using Exercise.Vue3Net5.WebApp.Services;

    using Microsoft.EntityFrameworkCore;

    using VueCliMiddleware;

    public class Startup
    {
        private readonly string MyAllowedOrigins = "_myAllowedOrigins";

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(o => o.AddPolicy(MyAllowedOrigins, ApplicationBuilder =>
            {
                //ApplicationBuilder.WithOrigins("*");
                ApplicationBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

            var connectionString = this.Configuration.GetConnectionString("DbConnection");

            services.AddDbContext<SampleDbContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<ProductService>();

            services.AddControllers();

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp";
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Exercise.Vue3Net5.WebApp", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Exercise.Vue3Net5.WebApp v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSpaStaticFiles();
            app.UseCors(MyAllowedOrigins);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                if (env.IsDevelopment())
                {
                    spa.Options.SourcePath = "ClientApp/";
                    spa.UseVueCli(npmScript: "serve --fix");
                }
                else
                {
                    spa.Options.SourcePath = "dist";
                }
            });
        }
    }
}
