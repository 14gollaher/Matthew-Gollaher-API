using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Pongo.BusinessLogic
{
    public class CellRepository : ICellRepository
    {
        private readonly PongoContext _context;
        private readonly PongoConfiguration _configuration;

        public CellRepository(PongoContext context, PongoConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void DeleteCell(int cellId)
        {
            Cell deleteCell = _context.Cells.FirstOrDefault(u => u.Id == cellId);
            _context.Cells.Remove(deleteCell);
            _context.SaveChanges();
        }

        public void UpdateCell(Cell cell)
        {
            _context.Cells.Add(cell);
            _context.Entry(cell).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Cell GetCell(int cellId)
        {
            return _context.Cells.FirstOrDefault(u => u.Id == cellId);
        }

        public List<Cell> GetCells()
        {
            return _context.Cells.ToList();
        }

        public List<Cell> GetCellsByColumn(int columnId)
        {
            return _context.Cells
                .Include(c => c.ColumnId)
                .ToList();
        }

        public void InsertCell(Cell cell)
        {
            _context.Cells.Add(cell);
            _context.SaveChanges();
        }
    }
}
