using System.Collections.Generic;

namespace SmashAPI.BusinessLogic
{
    public class Abilities
    {
        public List<Attack> Attacks { get; set; }
        public List<Grab> Grabs { get; set; }
        public List<Throw> Throws { get; set; }
        public List<Roll> Rolls { get; set; }
    }
}
