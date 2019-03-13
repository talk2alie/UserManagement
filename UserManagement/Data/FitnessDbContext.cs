using Microsoft.EntityFrameworkCore;

namespace UserManagement.Data
{
    public class FitnessDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public FitnessDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
