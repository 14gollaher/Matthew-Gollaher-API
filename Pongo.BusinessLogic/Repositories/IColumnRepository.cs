using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public interface IColumnRepository
    {
        void InsertColumn(Column column);
        List<Column> GetColumns();
        List<Column> GetColumnsByTable(int tableId);
        Column GetColumn(int columnId);
        void UpdateColumn(Column column);
        void DeleteColumn(int columnId);
    }
}