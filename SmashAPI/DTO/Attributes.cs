using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmashAPI
{
    public class Attributes
    {
        public double WeightValue { get; set; }
        public int WeightRank { get; set; }
        public double RunSpeedValue { get; set; }
        public int RunSpeedRank { get; set; }
        public double WalkSpeedValue { get; set; }
        public int WalkSpeedRank { get; set; }
        public double AirSpeedValue { get; set; }
        public int AirSpeedRank { get; set; }
        public double FallSpeedValue { get; set; }
        public int FallSpeedRank { get; set; }
        public double FastFallSpeedValue { get; set; }
        public int FastFallRank { get; set; }
        public int MaxJumps { get; set; }
        public bool WallJump { get; set; }
        public bool WallCling { get; set; }
        public bool Crawl { get; set; }
        public bool Tether { get; set; }
    }
}
