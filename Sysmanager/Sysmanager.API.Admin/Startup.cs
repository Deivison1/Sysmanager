using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sysmanager.Application.Data.Mysql;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Services;


namespace Sysmanager.API.Admin
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public void BeforeConfigureServices(IServiceCollection services)
        {

        }
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            BeforeConfigureServices(services);
            services.AddApiVersioning();
            services.AddScoped<UserService>();
            services.AddScoped<UserRepository>();
            services.AddScoped<MySqlContext>();
            services.Configure<AppConnectionSettings>(option => Configuration.GetSection("ConnectionStrings").Bind(option));

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc();
        }
    }
}
