using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using XCaseManager.Messenger.Models;

namespace XCaseManager.Messenger
{
    public class Startup
    {
        readonly string AllowedOriginPolicy = "corsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // container services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ExecutionDBContext>(opt =>
               opt.UseInMemoryDatabase("ExecutionList"));
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowedOriginPolicy,
                              builder =>
                              {
                                  builder.WithOrigins("http://localhost:3006",
                                                      "http://localhost:3005")
                                        .AllowAnyHeader()
                                        .WithMethods("GET", "POST", "PUT", "DELETE");
                              });
            });

            // services.AddResponseCaching();
             services.AddControllers();
        }

        // HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseCors(AllowedOriginPolicy);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
