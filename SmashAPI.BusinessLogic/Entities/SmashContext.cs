using Microsoft.EntityFrameworkCore;

namespace SmashAPI.BusinessLogic
{
    public class SmashContext : DbContext
    {
        public SmashContext(DbContextOptions<SmashContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Character> Characters { get; set; }
    }
}
