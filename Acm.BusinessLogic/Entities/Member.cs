using MatthewGollaherTools;
using System;
using System.ComponentModel.DataAnnotations;

namespace Acm.BusinessLogic
{
    public class Member : Base
    {
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
        public DateTime? MembershipExpiration { get; set; }
        [Required]
        [MaxLength(20)]
        public string StudentId { get; set; }
        [Required]
        [MaxLength(20)]
        public string AcmId { get; set; }
    }

    public enum OfficerPosition
    {
        President = 1,
        VicePresident,
        Secretary,
        Treasurer,
        JecRepresentative
    }
}
