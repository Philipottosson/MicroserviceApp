using Microsoft.EntityFrameworkCore;

namespace UserService.DAL
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UserContext(DbContextOptions options) : base(options)
        {

        }
    }
}
