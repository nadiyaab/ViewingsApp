using Microsoft.EntityFrameworkCore;
using ViewingsApp.Models.Database;

namespace ViewingsApp
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
        
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}