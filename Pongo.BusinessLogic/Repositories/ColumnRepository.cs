using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Pongo.BusinessLogic
{
    public class ColumnRepository : IColumnRepository
    {
        private readonly PongoContext _context;
        private readonly PongoConfiguration _configuration;

        public ColumnRepository(PongoContext context, PongoConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void DeleteColumn(int columnId)
        {
            Column deleteColumn = _context.Columns.FirstOrDefault(u => u.Id == columnId);
            _context.Columns.Remove(deleteColumn);
            _context.SaveChanges();
        }

        public void UpdateColumn(Column column)
        {
            _context.Columns.Add(column);
            _context.Entry(column).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Column GetColumn(int columnId)
        {
            return _context.Columns.FirstOrDefault(u => u.Id == columnId);
        }

        public List<Column> GetColumns()
        {
            return _context.Columns
                .Include(c => c.Cells)
                .ToList();
        }

        public List<Column> GetColumnsByTable(int tableId)
        {
            return _context.Columns
                .Where(t => t.TableId == tableId)
                .Include(c => c.Cells)
                .ToList();
        }

        public void InsertColumn(Column column)
        {
            _context.Columns.Add(column);
            _context.SaveChanges();
        }
    }
}
