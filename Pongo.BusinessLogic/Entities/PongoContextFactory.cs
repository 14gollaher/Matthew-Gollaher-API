using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pongo.BusinessLogic
{
    public class PongoContextFactory : IDesignTimeDbContextFactory<PongoContext>
    {
        private PongoConfiguration Configuration { get; set; }

        public PongoContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PongoContext>();
            builder.UseSqlServer("Secret");
            return new PongoContext(builder.Options);
        }
    }
}