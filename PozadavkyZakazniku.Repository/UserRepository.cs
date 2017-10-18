using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PozadavkyZakazniku.Model;
using AutoMapper;
using PozadavkyZakazniku.Repository.Interfaces;

namespace PozadavkyZakazniku.Repository
{
    public class UserRepository:IUserRepository 
    {
        public UserModel GetUser(int ID)
        {
            using (DbRequest db = new DbRequest() )
            {
                return Mapper.Map<UserModel>(db.Users.Where(u => u.UserID == ID).Select(u => u).FirstOrDefault());
            }

        }

        public ICollection<UserModel> GetUsers()
        {
            using (DbRequest db = new DbRequest())
            {
                return Mapper.Map<ICollection<UserModel>> (db.Users.Select(u => u));

            }
        }

        public UserModel CreateUser(UserModel user)
        {
            using (DbRequest db = new DbRequest())
            {
                var newUser = db.Users.Add(Mapper.Map<User>(user));

                db.SaveChanges();

                //user.UserID = newUser.UserID;
                //return user;

                return Mapper.Map<UserModel>(newUser);

            }

        }


        public void DeleteUser(int ID)
        {
            using (DbRequest db = new DbRequest()){

                db.Users.RemoveRange(db.Users.Where(u => u.UserID == ID));
                db.SaveChanges();
            }

        }

        public UserModel UpdateUser(UserModel user)
        {
            using (DbRequest db = new DbRequest())
            {
                var userdb = db.Users.Where(u => u.UserID == user.UserID).Select(u => u).FirstOrDefault();

                userdb = Mapper.Map<User>(user);
                //Mapper.Map(user, userdb); -david
                // co mapuji do ceho
                db.SaveChanges();

            }
            return user;
        }

    }
}
