using CodeFirst.PartTwo.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstPartTwo.Data 
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public CarContext(DbContextOptions options) : base(options)
        {
        
        }
    }
}
