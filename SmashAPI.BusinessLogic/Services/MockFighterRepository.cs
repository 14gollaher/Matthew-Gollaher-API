using System;
using System.Collections.Generic;

namespace WiiUSmash4.BusinessLogic
{
    public class MockFighterRepository : IFighterRepository
    {
        public void InsertFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }
        public Fighter GetFighter(int fighterId)
        {
            Fighter fighter = new Fighter
            {
                Id = fighterId,
                Name = "Bob",
                Title = "The Magnificent",
                PortraitPictureUrl = "http://www.sampleUrl"
            };

            Attributes attributes = new Attributes
            {
                Weight = 125.5,
                WeightRank = 30,
                RunSpeed = 20.2,
                RunSpeedRank = 5,
                WalkSpeed = 20.0,
                WalkSpeedRank = 7,
                AirSpeed = 199.2,
                AirSpeedRank = 14,
                FallSpeed = 12.1,
                FallSpeedRank = 16,
                FastFallSpeed = 61.14,
                FastFallSpeedRank = 19,
                AirAcceleration = 15.5,
                Gravity = 0.77,
                ShortHopAirTimeFrames = 5,
                FullHopAirTimeFrames = 7,
                MaximumJumps = 4,
                WallJump = false,
                WallCling = true,
                Crawl = true,
                Tether = false,
                JumpSquatFrames = 4,
                SoftLandingLagFrames = 3,
                HardLandingLagFrames = 4
            };
            fighter.Attributes = attributes;

            Attack attack1 = new Attack
            {
                Name = "Jab 1",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl1", "http://www.sampleUrl2" }),
                HitboxActiveRange = "3-4",
                FirstActionableFrame = 3,
                BaseDamage = "3-4",
                ShieldDamage = "4-5",
                Angle = "80/45",
                BaseKnockBack = "20/30",
                WeightBaseKnockBack = "40",
                KnockBackGrowth = "12"
            };
            fighter.Attacks = new List<Attack>(new Attack[] { attack1 });

            Attack attack2 = new Attack
            {
                Name = "F-Smash",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl3", "http://www.sampleUrl4" }),
                HitboxActiveRange = "21-22",
                FirstActionableFrame = 21,
                BaseDamage = "49",
                ShieldDamage = "50",
                Angle = "80/4",
                BaseKnockBack = "20",
                WeightBaseKnockBack = "40/50",
                KnockBackGrowth = "13"
            };
            fighter.Attacks.Add(attack2);

            Grab grab1 = new Grab
            {
                Name = "Standing Grab",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl4", "http://www.sampleUrl5" }),
                HitboxActiveRange = "6-7",
                FirstActionableFrame = 35
            };
            fighter.Grabs = new List<Grab>(new Grab[] { grab1 });

            Throw throw1 = new Throw
            {
                Name = "F-Throw",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl5", "http://www.sampleUrl6", "http://www.sampleUrl7" }),
                WeightDependent = true,
                BaseDamage = "11/12",
                ShieldDamage = "11",
                Angle = "45",
                BaseKnockBack = "45",
                KnockBackGrowth = "47"
            };
            fighter.Throws = new List<Throw>(new Throw[] { throw1 });

            Roll roll1 = new Roll
            {
                Name = "Spot Dodge",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl8", "http://www.sampleUrl9", "http://www.sampleUrl10" }),
                Intangibility = "3-18",
                FirstActionableFrame = 20
            };
            fighter.Rolls = new List<Roll>(new Roll[] { roll1 });

            Aerial aerial1 = new Aerial
            {
                Name = "Nair",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl11", "http://www.sampleUrl12", "http://www.sampleUrl13" }),
                HitboxActiveRange = "25-27",
                FirstActionableFrame = 36,
                BaseDamage = "11",
                ShieldDamage = "12",
                Angle = "361",
                BaseKnockBack = "23",
                WeightBaseKnockBack = null,
                KnockBackGrowth = "100",
                LandingLag = "18",
                AutoCancelFrames = "1-4, 26>"
            };
            fighter.Aerials = new List<Aerial>(new Aerial[] { aerial1 });


            Special special1 = new Special
            {
                Name = "PK Trash (No Charge)",
                AbilityFramePictureUrls = new List<string>(new string[] { "http://www.sampleUrl14", "http://www.sampleUrl15", "http://www.sampleUrl16" }),
                HitboxActiveRange = "43",
                FirstActionableFrame = 69,
                BaseDamage = "9",
                ShieldDamage = "9",
                Angle = "70",
                BaseKnockBack = "10",
                WeightBaseKnockBack = "20",
                KnockBackGrowth = "70"
            };
            fighter.Specials = new List<Special>(new Special[] { special1 });

            return fighter;
        }

        public IEnumerable<Fighter> GetFighters()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Icon> GetIcons()
        {
            throw new NotImplementedException();
        }
        public void UpdateFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }
        public void DeleteFighter(int fighterId)
        {
            throw new NotImplementedException();
        }
    }
}
