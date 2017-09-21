using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Acm.BusinessLogic
{
    public class AcmContextFactory : IDesignTimeDbContextFactory<AcmContext>
    {
        private AcmConfiguration Configuration { get; set; }

        public AcmContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AcmContext>();
            builder.UseSqlServer(Configuration.AcmDbConnectionString);

            return new AcmContext(builder.Options);
        }
    }
}