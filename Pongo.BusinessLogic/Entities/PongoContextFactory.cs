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
            builder.UseSqlServer("Server=tcp:matthewgollaher.database.windows.net,1433;Initial Catalog=Pongo;Persist Security Info=False;User ID=gollaher14;Password=ABCmeow123!!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //builder.UseSqlServer(Configuration.PongoDbConnectionString);

            return new PongoContext(builder.Options);
        }
    }
}