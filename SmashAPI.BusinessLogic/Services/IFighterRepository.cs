using System.Collections.Generic;

namespace WiiUSmash4.BusinessLogic
{
    public interface IFighterRepository
    {
        void InsertFighter(Fighter fighter);
        IEnumerable<Fighter> GetFighters();
        Fighter GetFighter(int fighterId);
        IEnumerable<Icon> GetIcons();
        void UpdateFighter(Fighter fighter);
        void DeleteFighter(int fighterId);
    }
}
