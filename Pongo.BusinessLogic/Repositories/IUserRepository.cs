using System.Collections.Generic;

namespace Pongo.BusinessLogic
{
    public interface IUserRepository
    {
        void InsertUser(User user);
        List<User> GetUsers();
        User GetUser(int userId);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}