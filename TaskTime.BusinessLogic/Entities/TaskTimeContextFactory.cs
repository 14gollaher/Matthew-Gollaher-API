using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaskTime.BusinessLogic
{
    public class TaskTimeContextFactory : IDesignTimeDbContextFactory<TaskTimeContext>
    {
        private TaskTimeConfiguration Configuration { get; set; }

        public TaskTimeContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TaskTimeContext>();
            builder.UseSqlServer(Configuration.TaskTimeDbConnectionString);

            return new TaskTimeContext(builder.Options);
        }
    }
}
