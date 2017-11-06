using GlobalTools;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class Cell : Base
    {
        [Required]
        [MaxLength(8000)]
        public string Value { get; set; }
        [Required]
        public int Row { get; set; }
        [Required]
        public int ColumnId { get; set; }
    }
}