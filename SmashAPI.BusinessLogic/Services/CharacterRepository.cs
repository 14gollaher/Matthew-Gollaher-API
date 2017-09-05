using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SmashAPI.BusinessLogic
{
    public class CharacterRepository : ICharacterRepository
    {
        private SmashContext _context;

        public CharacterRepository(SmashContext context)
        {
            _context = context;
        }

        public IEnumerable<Character> GetCharacters()
        {
            return _context.Characters.FromSql(DatabaseDefines.Character_GetCharacters).ToList();
        }
    }
}
