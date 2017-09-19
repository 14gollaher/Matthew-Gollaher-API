using Microsoft.EntityFrameworkCore;

namespace Acm.BusinessLogic
{
    public class AcmContext : DbContext
    {
        public AcmContext(DbContextOptions<AcmContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Member> Members { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(DatabaseDefines.AcmDbConnectionString);
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
