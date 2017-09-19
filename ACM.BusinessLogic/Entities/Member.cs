using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acm.BusinessLogic
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(120)]
        public string Email { get; set; }
        [Required]
        public OfficerPosition OfficerPostion { get; set; }
        [Required]
        public DateTime? MembershipExpiration { get; set; }
        [Required]
        public string StudentId { get; set; }
        public string AcmId { get; set; }
    }

    public enum OfficerPosition
    {
        President,
        VicePresident,
        Secretary,
        Treasurer,
        JecRepresentative
    }
}
