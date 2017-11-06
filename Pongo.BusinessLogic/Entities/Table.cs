using GlobalTools;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class Table : Base
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public ICollection<Column> Columns { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
