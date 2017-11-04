using GlobalTools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Pongo.BusinessLogic
{
    public class PongoContext : DbContext
    {
        public PongoContext(DbContextOptions<PongoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Table> Tables { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Row>().ToTable("Row");
            modelBuilder.Entity<Column>().ToTable("Column");
            modelBuilder.Entity<Table>().ToTable("Table");
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
