using DAL.Pathology;
using DAL.Pathology.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PMS.Repository.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS
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
            services.AddSession();
            services.AddControllersWithViews();
            services.AddScoped<ICommonRepository, CommonRepository>();
            services.AddScoped<ICommonDAL, CommonDAL>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyDAL, CompanyDAL>(); 
            services.AddScoped<ILabStaffRepository, LabStaffRepository>();
            services.AddScoped<IDoctorDAL, DoctorDAL>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<ILabStaffDAL, LabStaffDAL>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginDAL, LoginDAL>();
            services.AddScoped<IMaintainMasterRepository, MaintainMasterRepository>();
            services.AddScoped<IMaintainMasterDAL, MaintainMasterDAL>();
            services.AddMemoryCache();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=UserLogin}/{id?}");
            });
        }
    }
}
