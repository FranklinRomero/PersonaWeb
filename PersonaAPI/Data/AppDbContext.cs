using Microsoft.EntityFrameworkCore;

namespace PersonaAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<PersonaAPI.Models.Person> Person { get; set; }
    }
}
