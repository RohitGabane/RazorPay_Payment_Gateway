using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Payment_Gateway.Models
{
    public class RegistrationModelDbContext : DbContext
    {
        public RegistrationModelDbContext()
        {
        }
   

        public RegistrationModelDbContext(DbContextOptions<RegistrationModelDbContext> options) : base(options)
        {
        }
        public DbSet<RegistrationModel> RegistrationModels { get; set; }
        public DbSet<OrderModel> OrderModels { get; set; }
        public DbSet<RazorPayOptionsModel> RazorPayOptionsModels { get; set; }
    }
}
