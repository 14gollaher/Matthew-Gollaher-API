using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterRepository : IFighterRepository
    {
        private SmashContext _context;

        public FighterRepository(SmashContext context)
        {
            _context = context;
        }

        public void InsertFighter(Fighter fighter)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Fighter> GetFighters()
        {
            return _context.Fighters.FromSql(DatabaseDefines.Fighter_GetFighters).ToList();
        }

        public Fighter GetFighter(int fighterId)
        {
            return _context.Fighter.FromSql(DatabaseDefines.Fighter_GetFighter).Single();
        }

        public void UpdateFighter(Fighter fighter)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFighter(int fighterId)
        {
            throw new System.NotImplementedException();
        }
    }
}
