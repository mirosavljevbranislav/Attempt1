using CodeFirt.Data;
using CodeFirstPartTwo.Data;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.API
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CollegeContext>(options =>
            {
                options
                .UseSqlServer(_configuration.GetConnectionString("CollegeConnection"));
            });
            services.AddDbContext<CarContext>(options =>
            {
                options
                .UseSqlServer(_configuration.GetConnectionString("CarConnection"));
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddControllers();

            // Repositories

            // Business Logic
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
