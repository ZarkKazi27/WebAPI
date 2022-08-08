using APItesting.DepartmentService;
using APItesting.EmployeeService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace APItesting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        /*{
            services.AddSingleton<ITest, Test2>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {

            });
        }*/
        

        public void ConfigureServices(IServiceCollection services)    
        {
            services.AddControllersWithViews();
            services.AddSession();
            

            services.AddControllers();
            services.AddSingleton<ITest, Test2>();
            services.AddDbContextPool<EmployeeContext>(options => options.UseSqlServer(Configuration["EmployeeDBContextConnectionString"]));
            services.AddDbContextPool<DepartmentContext>(options => options.UseSqlServer(Configuration["EmployeeDBContextConnectionString"]));
            services.AddScoped<IEmployeeService, EmployeeService.EmployeeService>();
            services.AddSwaggerGen(c =>
            {

            });

            services.AddScoped<IDepartmentService, DepartmentService.DepartmentService>();

        }   
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
