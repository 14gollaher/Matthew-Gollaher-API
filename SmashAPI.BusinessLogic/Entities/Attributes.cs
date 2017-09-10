namespace WiiUSmash4.BusinessLogic
{
    public class Attributes
    {
        public double Weight { get; set; }
        public int WeightRank { get; set; }
        public double RunSpeed { get; set; }
        public int RunSpeedRank { get; set; }
        public double WalkSpeed { get; set; }
        public int WalkSpeedRank { get; set; }
        public double AirSpeed { get; set; }
        public int AirSpeedRank { get; set; }
        public double FallSpeed { get; set; }
        public int FallSpeedRank { get; set; }
        public double FastFallSpeed { get; set; }
        public int FastFallSpeedRank { get; set; }
        public double AirAcceleration { get; set; }
        public double Gravity { get; set; }
        public double ShortHopAirTime { get; set; }
        public double LongHopAirTime { get; set; }
        public int MaximumJumps { get; set; }
        public bool WallJump { get; set; }
        public bool WallCling { get; set; }
        public bool Crawl { get; set; }
        public bool Tether { get; set; }
        public int JumpSquatFrameCount { get; set; }
        public int SoftLandingLag { get; set; }
        public int HardLandingLag { get; set; }
    }
}
