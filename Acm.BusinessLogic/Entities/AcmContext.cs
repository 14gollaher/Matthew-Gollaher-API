using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Acm.BusinessLogic
{
    public class AcmContext : DbContext
    {
        public AcmContext(DbContextOptions<AcmContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
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
