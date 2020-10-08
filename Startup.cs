using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using XCaseManager.ReportService.Models;
using XCaseManager.ReportService.Services;


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
        
            services.Configure<DBSettings>(
                Configuration.GetSection(nameof(DBSettings)));

            services.AddSingleton<IDBSettings>(sp =>
                sp.GetRequiredService<IOptions<DBSettings>>().Value);

            services.AddSingleton<ProjectService>();
            services.AddSingleton<TestcaseService>();

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
