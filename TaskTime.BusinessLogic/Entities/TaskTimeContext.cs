using MatthewGollaherTools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TaskTime.BusinessLogic
{
    public class TaskTimeContext : DbContext
    {
        public TaskTimeContext(DbContextOptions<TaskTimeContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().ToTable("Task");
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            AddAuditInfo();
            return base.SaveChanges();
        }

        public void SaveChangesAsync()
        {
            AddAuditInfo();
            base.SaveChangesAsync();
        }

        private void AddAuditInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((Base)entry.Entity).Created = DateTime.UtcNow;
                }
            ((Base)entry.Entity).Modified = DateTime.UtcNow;
            }
        }
    }
}
