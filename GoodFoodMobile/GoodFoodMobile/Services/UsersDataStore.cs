using GoodFoodMobile.Models;
using GoodFoodMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodMobile.Services
{
    public class UsersDataStore : IUsersDataStore<User>
    {
        public  List<User> users;

        public UsersDataStore()
        {
            users = new List<User>()
            {
                new User { id = Guid.NewGuid().ToString(), lastName = "Devin", firstName = "Teddy", email = "teddy.devin@viacesi.fr", password = "123", address = "70 rue entre deux landes" , postalCode = "76220", city ="La Feuillie" },
                new User { id = Guid.NewGuid().ToString(), lastName = "John", firstName = "Doe", email = "john.doe@viacesi.fr", password = "123", address = "2 rue des portiers" , postalCode = "76000", city ="Rouen" }
            };
        }

        #region Users

        /// <summary>
        /// ajout d'un utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddUserAsync(User user)
        {
            users.Add(user);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Mise à jour d'un utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUserAsync(User user)
        {
            var oldUser = users.Where((User arg) => arg.email == user.email).FirstOrDefault();
            users.Remove(oldUser);
            users.Add(user);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// suppresion d'un utilisateur
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserAsync(string email)
        {
            var oldUser = users.Where((User arg) => arg.email == email).FirstOrDefault();
            users.Remove(oldUser);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// renvoie l'utilisateur lié à l'email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUserAsync(string email)
        {
            return await Task.FromResult(users.FirstOrDefault(u => u.email == email));
        }

        /// <summary>
        /// renvoie la liste des utilisateurs
        /// </summary>
        /// <param name="forceRefresh"></param>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            // TODO : appel api pour récupérer les utilisateurs
            return users;
        }


        public void AddUser(User user)
        {
            users.Add(user);
        }

        #endregion
    }
}
