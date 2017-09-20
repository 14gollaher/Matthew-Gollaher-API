using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Acm.BusinessLogic
{
    public class AcmContextFactory : IDesignTimeDbContextFactory<AcmContext>
    {
        public AcmContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AcmContext>();
            builder.UseSqlServer(DatabaseDefines.AcmDbConnectionString);

            return new AcmContext(builder.Options);
        }
    }
}