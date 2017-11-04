using GlobalTools;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class Cell : Base
    {
        [Required]
        [MaxLength(50)]
        public string Value { get; set; }
    }
}