using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFrameworkList.Infra.CrossCutting.IOC;
using MyFrameworkList.Infra.Data;

namespace MyFrameworkList.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connectionString = Configuration["ConnectionStrings:MyFrameworkListDb"];

            services.AddDbContext<ApplicationDbContext>(opt => opt.UseMySql(connectionString, b => b.MigrationsAssembly("MyFrameworkList.API")));

            services.AddSwaggerGen();
        }

        public void ConfigureContainer(ContainerBuilder builder) => builder.RegisterModule(new ModuleIOC());


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyFrameworkList"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
