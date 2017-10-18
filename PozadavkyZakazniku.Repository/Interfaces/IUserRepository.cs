using System.Collections.Generic;
using PozadavkyZakazniku.Model;

namespace PozadavkyZakazniku.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel CreateUser(UserModel user);
        void DeleteUser(int ID);
        UserModel GetUser(int ID);
        ICollection<UserModel> GetUsers();
        UserModel UpdateUser(UserModel user);
    }
}