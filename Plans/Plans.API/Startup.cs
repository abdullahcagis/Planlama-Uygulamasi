using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plans.Business.Abstract;
using Plans.Business.Concrete;
using Plans.DataAcessLayer.Abstract;
using Plans.DataAcessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plans.API
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
            services.AddControllers();
            services.AddSingleton<IPlansService, PlansManager>();
            services.AddSingleton<IPlansRepository, PlansRepository>();
            services.AddSwaggerDocument(configure=>
            {
                configure.PostProcess = (doc =>
                {
                    doc.Info.Title = "Planlar Api";
                    doc.Info.Version = "1.0.26";
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                        Name = "Mustafa Abdullah Çaðýþ",
                        Url = "https://www.linkedin.com/in/mustafaabdullahcagi%CC%87s/",
                        Email = "mustafabdullah1126@gmail.com"
                    };
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
