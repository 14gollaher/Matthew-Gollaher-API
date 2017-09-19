using System;
using System.Collections.Generic;

namespace Acm.BusinessLogic
{
    public class MemberDataStore
    {
        public static MemberDataStore Current { get; } = new MemberDataStore();
        public List<Member> Members { get; set; }

        public MemberDataStore()
        {
            Members = new List<Member>()
            {
                new Member()
                {
                    Id = 1,
                    FirstName = "Matthew",
                    LastName = "Gollaher",
                    Email = "matthew.gollaher@jacks.sdstate.edu",
                    OfficerPostion = OfficerPosition.President,
                    MembershipExpiration = new DateTime(2018, 02, 01),
                    StudentId = "7249864",
                    AcmId = "012345"
                },
                new Member()
                {
                    Id = 2,
                    FirstName = "Mitchell",
                    LastName = "Petite",
                    Email = "mitchell.petite@jacks.sdstate.edu",
                    OfficerPostion = OfficerPosition.VicePresident,
                    MembershipExpiration = new DateTime(2018, 02, 01),
                    StudentId = "745123",
                    AcmId = "4532353"
                }
            };
        }
    }
}
