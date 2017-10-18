using System.Collections.Generic;
using PozadavkyZakazniku.Model;

namespace PozadavkyZakazniku.Service.Interfaces
{
    public interface IUserService
    {
        UserModel CreateUser(UserModel user);
        void DeleteUser(int ID);
        UserModel GetUser(int ID);
        ICollection<UserModel> GetUsers();
        UserModel UpdateUser(UserModel user);
    }
}