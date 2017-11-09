using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public interface ICellRepository
    {
        void InsertCell(Cell cell);
        List<Cell> GetCells();
        List<Cell> GetCellsByColumn(int cellId);
        Cell GetCell(int cellId);
        void UpdateCell(Cell cell);
        void DeleteCell(int cellId);
    }
}