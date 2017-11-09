using GlobalTools;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class Column : Base
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public ColumnType Type { get; set; }
        [Required]
        public bool Required { get; set; }
        [Required]
        public int ColumnOrder { get; set; }
        [Required]
        public ICollection<Cell> Cells { get; set; }
        [Required]
        public int TableId { get; set; }
    }
    public enum ColumnType
    {
        Number,
        Text,
        YesNo,
        Picture
    }
}
