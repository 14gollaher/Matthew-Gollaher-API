using Microsoft.EntityFrameworkCore;

namespace WiiUSmash4.BusinessLogic
{
    public class SmashContext : DbContext
    {
        public SmashContext(DbContextOptions<SmashContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Fighter> Fighter { get; set; }
    }
}
