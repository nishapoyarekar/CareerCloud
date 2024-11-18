using Microsoft.OpenApi.Models;

namespace CareerCloud.WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ni's Career Cloud API", Version = "v1" });
            });
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder appBuilder, IWebHostEnvironment env)
        {
            appBuilder.UseSwagger();
            appBuilder.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ni's Career Cloud API V1");
            });

            appBuilder.UseRouting();
            appBuilder.UseAuthorization();

            appBuilder.UseEndpoints(end => { end.MapControllers(); });
        }
        
    }
}
