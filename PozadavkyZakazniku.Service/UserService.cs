using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PozadavkyZakazniku.Model;
using PozadavkyZakazniku.Repository.Interfaces;
using PozadavkyZakazniku.Service.Interfaces;



namespace PozadavkyZakazniku.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepository userRepository; 
        

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserModel GetUser(int ID)
        {
            return userRepository.GetUser(ID);

        }

        public ICollection<UserModel> GetUsers()
        {

            return userRepository.GetUsers();

        }

        public UserModel CreateUser(UserModel user)
        {
            return userRepository.CreateUser(user);

        }


        public void DeleteUser(int ID)
        {
            userRepository.DeleteUser(ID);

        }

        public UserModel UpdateUser(UserModel user)
        {
            return userRepository.UpdateUser(user);
        }

    }
}
