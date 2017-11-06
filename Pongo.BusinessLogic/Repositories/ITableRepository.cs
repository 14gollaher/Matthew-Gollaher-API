using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public interface ITableRepository
    {
        void InsertTable(Table table);
        List<Table> GetTables();
        List<Table> GetTablesByUser(int userId);
        Table GetTable(int tableId);
        void UpdateTable(Table table);
        void DeleteTable(int tableId);
    }
}