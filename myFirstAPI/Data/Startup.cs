using Microsoft.EntityFrameworkCore;
using myFirstAPI.Data.myFirstAPI.Data;

namespace myFirstAPI.Data
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase("InMemoryDb"));
        }

        public void Configure(IApplicationBuilder app)
        {
        }
    }
}
