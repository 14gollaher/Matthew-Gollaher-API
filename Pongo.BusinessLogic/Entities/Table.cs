using GlobalTools;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class Table : Base
    {
        [Required]
        public List<Column> Columns { get; set; }
        [Required]
        public List<Row> Rows { get; set; }
    }
}
