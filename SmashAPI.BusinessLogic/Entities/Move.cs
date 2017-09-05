using System.Collections.Generic;

namespace SmashAPI.BusinessLogic
{
    public class Attack : Move
    {
        public string HitboxActiveRange { get; set; } 
        public int FirstActionableFrame { get; set; }
        public int BaseDamage { get; set; }
        public int Angle { get; set; }
        public int BaseKnockBack { get; set; }
        public int KnockBackGrowth { get; set; }
    }

    public class Grab : Move
    {
        public string HitboxActiveRange { get; set; }

        public int FirstActionableFrame { get; set; }
    }

    public class Throw : Move
    {
        public int BaseDamage { get; set; }
        public int Angle { get; set; }
        public int BaseKnockBack { get; set; }
        public int KnockBackGrowth { get; set; }
    }

    public class Roll : Move
    {
        public int Intangibility { get; set; }
        public int FirstActionableFrame { get; set; }
    }

    public class Aerial : Move
    {
        public string HitboxActiveRange { get; set; }
        public int FirstActionableFrame { get; set; }
        public int BaseDamage { get; set; }
        public int Angle { get; set; }
        public int BaseKnockBack { get; set; }
        public int KnockBackGrowth { get; set; }
        public int LandingLag { get; set; }
        public string AutoCancelFrames { get; set; }
    }

    public class Special : Attack
    {

    }

    public class Move
    {
        public string Name { get; set; }
        public List<byte[]> AttackFrames { get; set; }
    }
}
