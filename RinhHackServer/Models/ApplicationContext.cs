using Microsoft.EntityFrameworkCore;

namespace RinhHackServer.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<UserModel> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
