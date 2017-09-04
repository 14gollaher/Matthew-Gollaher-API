using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmashAPI.DTO
{
    public class Abilities
    {
        public List<Attack> Attacks { get; set; }
        public List<Grab> Grabs { get; set; }
        public List<Throw> Throws { get; set; }
        public List<Roll> Rolls { get; set; }



    }
}
