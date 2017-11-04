using System;
using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public class MockTableRepository : ITableRepository
    {
        public void DeleteTable(int tableId)
        {
            throw new NotImplementedException();
        }

        public Table GetTable(int tableId)
        {
            throw new NotImplementedException();
        }

        public List<Table> GetTables()
        {
            List<Column> columns = new List<Column>();
            Column column = new Column()
            {
                Name = "AcmId",
                Type = Column.ColumnType.Number,
                Required = false
            };
            columns.Add(column);

            column = new Column()
            {
                Name = "Name",
                Type = Column.ColumnType.Text,
                Required = false
            };
            columns.Add(column);

            List<Row> rows = new List<Row>();
            List<Cell> cells = new List<Cell>();
            Cell cell = new Cell()
            {
                Value = "7249864"
            };
            cells.Add(cell);
            cell = new Cell()
            {
                Value = "Matthew Gollaher"
            };
            cells.Add(cell);
            Row row = new Row()
            {
                Cells = cells
            };
            rows.Add(row);

            cells = new List<Cell>();
            cell = new Cell()
            {
                Value = "1234567"
            };
            cells.Add(cell);
            cell = new Cell()
            {
                Value = "Bob Barker"
            };
            cells.Add(cell);
            row = new Row()
            {
                Cells = cells
            };
            rows.Add(row);

            Table table = new Table()
            {
                Columns = columns,
                Rows = rows
            };

            List<Table> tables = new List<Table>
            {
                table
            };

            return tables;
        }

        public void InsertTable(Table table)
        {
            throw new NotImplementedException();
        }

        public void UpdateTable(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
