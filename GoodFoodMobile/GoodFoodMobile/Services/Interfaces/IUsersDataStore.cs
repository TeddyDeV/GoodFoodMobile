using GoodFoodMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodMobile.Services.Interfaces
{
    public interface IUsersDataStore<T>
    {
        #region Users
        Task<bool> AddUserAsync(T user);
        Task<bool> UpdateUserAsync(T user);
        Task<bool> DeleteUserAsync(string email);
        Task<T> GetUserAsync(string email);
        //IEnumerable<T> GetUsersAsync(bool forceRefresh = false);

        List<T> GetUsers();
        void AddUser(User user);
        #endregion
    }
}
