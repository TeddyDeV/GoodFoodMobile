using GoodFoodMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodMobile.Services.Interfaces
{
    public interface IRestaurantsDataStore<T>
    {
        #region Restaurants
        Task<bool> AddRestaurantsAsync(T restaurant);
        Task<bool> UpdateRestaurantAsync(T restaurant);
        Task<bool> DeleteRestaurantAsync(string email);
        Task<T> GetRestaurantAsync(string email);
        //IEnumerable<T> GetRestaurantsAsync(bool forceRefresh = false);

        List<T> GetRestaurants();
        void AddRestaurant(Restaurant restaurant);
        #endregion
    }
}
