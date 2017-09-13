using System.Collections.Generic;

namespace WiiUSmash4.BusinessLogic
{
    public class Attack : Move
    {
        public string HitboxActiveRange { get; set; } 
        public int FirstActionableFrame { get; set; }
        public string BaseDamage { get; set; }
        public string ShieldDamage { get; set; }
        public string Angle { get; set; }
        public string BaseKnockBack { get; set; }
        public string WeightBaseKnockBack { get; set; }
        public string KnockBackGrowth { get; set; }
    }

    public class Grab : Move
    {
        public string HitboxActiveRange { get; set; }
        public int FirstActionableFrame { get; set; }
    }

    public class Throw : Move
    {
        public bool WeightDependent { get; set; }
        public string BaseDamage { get; set; }
        public string ShieldDamage { get; set; }
        public string Angle { get; set; }
        public string BaseKnockBack { get; set; }
        public string KnockBackGrowth { get; set; }
    }

    public class Roll : Move
    {
        public string Intangibility { get; set; }
        public int FirstActionableFrame { get; set; }
    }

    public class Aerial : Move
    {
        public string HitboxActiveRange { get; set; }
        public int FirstActionableFrame { get; set; }
        public string BaseDamage { get; set; }
        public string ShieldDamage { get; set; }
        public string Angle { get; set; }
        public string BaseKnockBack { get; set; }
        public string WeightBaseKnockBack { get; set; }
        public string KnockBackGrowth { get; set; }
        public string LandingLag { get; set; }
        public string AutoCancelFrames { get; set; }
    }

    public class Special : Move
    {
        public string HitboxActiveRange { get; set; }
        public int FirstActionableFrame { get; set; }
        public string BaseDamage { get; set; }
        public string ShieldDamage { get; set; }
        public string Angle { get; set; }
        public string BaseKnockBack { get; set; }
        public string WeightBaseKnockBack { get; set; }
        public string KnockBackGrowth { get; set; }
    }

    public class Move
    {
        public string Name { get; set; }
        public List<string> AbilityFramePictureUrls { get; set; }
    }
}
