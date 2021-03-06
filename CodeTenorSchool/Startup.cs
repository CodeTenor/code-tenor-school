using CodeTenorSchool.Application.Contracts;
using CodeTenorSchool.Application.Contracts.IContracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CodeTenorSchool.ExceptionHandler;
using CodeTenorSchool.DataAccess;
using Microsoft.EntityFrameworkCore;
using CodeTenorSchool.DataAccess.Repositories;

namespace CodeTenorSchool
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
            // need to implement this
            services.AddAuthentication(AzureADB2CDefaults.BearerAuthenticationScheme)
                .AddAzureADB2CBearer(options => Configuration.Bind("AzureAdB2C", options));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IStudentContract, StudentContract>();

            services.AddControllers();

            services.AddDbContext<CodeTenorSchoolDBContext>(options =>
                options.UseSqlServer("Server=.;Database=CodeTenorSchool;Trusted_Connection=True;MultipleActiveResultSets=true"));

            services.AddScoped<ICodeTenorSchoolDBContext>(provider => provider.GetService<CodeTenorSchoolDBContext>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureExceptionHanlder();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}