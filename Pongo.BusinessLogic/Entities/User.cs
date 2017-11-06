using GlobalTools;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pongo.BusinessLogic
{
    public class User : Base
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
