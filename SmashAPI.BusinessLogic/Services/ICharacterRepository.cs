using System.Collections.Generic;
using System.Data;

namespace SmashAPI.BusinessLogic
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetCharacters();
    }
}
