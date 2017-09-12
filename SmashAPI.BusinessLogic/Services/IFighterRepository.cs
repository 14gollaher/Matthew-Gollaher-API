using System.Collections.Generic;

namespace WiiUSmash4.BusinessLogic
{
    public interface IFighterRepository
    {
        void InsertFighter(Fighter fighter);
        IEnumerable<Fighter> GetFighters();
        Fighter GetFighter(int fighterId);
        void UpdateFighter(Fighter fighter);
        void DeleteFighter(int fighterId);
    }
}
