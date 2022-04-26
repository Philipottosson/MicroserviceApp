using Microsoft.EntityFrameworkCore;
namespace GameService.DAL
{
    public class GameContext : DbContext
    {
        public DbSet<Games> Users { get; set; }

        public GameContext(DbContextOptions options) : base(options)
        {

        }
    }
}
