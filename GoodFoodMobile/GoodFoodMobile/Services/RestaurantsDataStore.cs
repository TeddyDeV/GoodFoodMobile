using GoodFoodMobile.Models;
using GoodFoodMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodFoodMobile.Services
{
    public class RestaurantsDataStore : IRestaurantsDataStore<Restaurant>
    {
        public List<Restaurant> restaurants;

        public RestaurantsDataStore()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { id = Guid.NewGuid().ToString(), name ="O'Tacos", address ="5 rue de la république", postalCode ="76000", city ="Rouen" , email="otacos-rouen@gmail.com", phoneNumber ="0235684952"},
                new Restaurant { id = Guid.NewGuid().ToString(), name ="Pittaya", address ="Centre commercial des Dock76", postalCode ="76000", city ="Rouen" , email="pittaya@gmail.com", phoneNumber ="0235894253"},
                new Restaurant { id = Guid.NewGuid().ToString(), name ="Chez Paulo", address ="chemins de la poste", postalCode ="76220", city ="La Feuillie" , email="paulo@gmail.com", phoneNumber ="0684932015"},
                new Restaurant { id = Guid.NewGuid().ToString(), name ="Mcdo", address ="zone exploitation", postalCode ="76220", city ="Ferrier-en-bray" , email="mcdo76@gmail.com", phoneNumber ="0235714630"}
                
            };
        }

        #region Restaurants

        /// <summary>
        /// ajout d'un utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddRestaurantAsync(Restaurant restaurant)
        {
            restaurants.Add(restaurant);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Mise à jour d'un utilisateur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> UpdateRestaurantAsync(Restaurant restaurant)
        {
            var oldRestaurant = restaurants.Where((Restaurant arg) => arg.email == restaurant.email).FirstOrDefault();
            restaurants.Remove(restaurant);
            restaurants.Add(restaurant);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// suppresion d'un utilisateur
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> DeleteRestaurantAsync(string email)
        {
            var oldUser = restaurants.Where((Restaurant arg) => arg.email == email).FirstOrDefault();
            restaurants.Remove(oldUser);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// renvoie le restaurant lié à l'email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<Restaurant> GetRestaurantAsync(string email)
        {
            return await Task.FromResult(restaurants.FirstOrDefault(u => u.email == email));
        }

        /// <summary>
        /// renvoie la liste des restaurants
        /// </summary>
        /// <param name="forceRefresh"></param>
        /// <returns></returns>
        public List<Restaurant> GetRestaurants()
        {
            // TODO : appel api pour récupérer les restaurants
            return restaurants;
        }

        /// <summary>
        /// Ajoute un restaurant
        /// </summary>
        /// <param name="user"></param>
        public void AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

        public Task<bool> AddRestaurantsAsync(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
