using System.Collections.Generic;

namespace WiiUSmash4.BusinessLogic
{
    public class Fighter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string PortraitPictureUrl { get; set; }
        public Attributes Attributes { get; set; }
        public List<Attack> Attacks { get; set; }
        public List<Grab> Grabs { get; set; }
        public List<Throw> Throws { get; set; }
        public List<Roll> Rolls { get; set; }
        public List<Aerial> Aerials { get; set; }
        public List<Special> Specials { get; set; }

    }
}
