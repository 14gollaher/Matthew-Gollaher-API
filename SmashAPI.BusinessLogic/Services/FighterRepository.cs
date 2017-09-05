using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SmashAPI.BusinessLogic
{
    public class FighterRepository : IFighterRepository
    {
        private SmashContext _context;

        public FighterRepository(SmashContext context)
        {
            _context = context;
        }

        public IEnumerable<Fighter> GetFighters()
        {
            return _context.Fighters.FromSql(DatabaseDefines.Fighter_GetFighters).ToList();
        }
    }
}
