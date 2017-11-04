using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public interface ITableRepository
    {
        void InsertTable(Table table);
        List<Table> GetTables();
        Table GetTable(int tableId);
        void UpdateTable(Table table);
        void DeleteTable(int tableId);
    }
}