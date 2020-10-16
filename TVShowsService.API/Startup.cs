using EFCImplementation.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TVShowsService.App.Interfaces.Commands;
using TVShowsService.App.Interfaces.Commands.Show;
using TVShowsService.EFCDataAccess;
using TVShowsService.EFCImplementation.Show;

namespace TVShowsService.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string MyAllowSpecificOrigins = "Any";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TVShowsServiceContext>();
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins, builder => builder.WithOrigins("http://localhost:8080").AllowAnyHeader().AllowCredentials().AllowAnyMethod());
            });

            services.AddControllers();

            //users

            services.AddTransient<IAddUserInterface, EFCAddUserImplementation>();

            //shows

            services.AddScoped<IGetShowsInterface, EFCGetShowsImplementation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
