using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Pongo.BusinessLogic
{
    public class TableRepository : ITableRepository
    {
        private readonly PongoContext _context;
        private readonly PongoConfiguration _configuration;

        public TableRepository(PongoContext context, PongoConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void DeleteTable(int tableId)
        {
            Table deleteTable = _context.Tables.FirstOrDefault(u => u.Id == tableId);
            _context.Tables.Remove(deleteTable);
            _context.SaveChanges();
        }

        public void UpdateTable(Table table)
        {
            _context.Tables.Add(table);
            _context.Entry(table).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Table GetTable(int tableId)
        {
            return _context.Tables.FirstOrDefault(u => u.Id == tableId);
        }

        public List<Table> GetTables()
        {
            return _context.Tables
                .Include(t => t.Columns)
                     .ThenInclude(c => c.Cells)
                .ToList();
        }

        public List<Table> GetTablesByUser(int userId)
        {
            return _context.Tables
                .Where(u => u.UserId == userId)
                .Include(t => t.Columns)
                     .ThenInclude(c => c.Cells)
                .ToList();
        }

        public void InsertTable(Table table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }
    }
}
