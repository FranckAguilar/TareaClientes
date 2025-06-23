using demoasp1.Models;
using Microsoft.EntityFrameworkCore;

namespace demoasp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Familia> Familia { get; set; }
        
        public DbSet<Cliente> Cliente {get; set; }
    }
}