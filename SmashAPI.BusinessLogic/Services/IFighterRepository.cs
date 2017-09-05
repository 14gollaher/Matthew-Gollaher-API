using System.Collections.Generic;
using System.Data;

namespace SmashAPI.BusinessLogic
{
    public interface IFighterRepository
    {
        IEnumerable<Fighter> GetFighters();
    }
}
