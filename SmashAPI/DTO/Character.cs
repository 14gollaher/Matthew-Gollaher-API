using SmashAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmashAPI
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] PortratiPicture { get; set; }
        Attributes CharacterAttributes { get; set; }
        Abilities CharacterAbilities { get; set; }
    }
}
