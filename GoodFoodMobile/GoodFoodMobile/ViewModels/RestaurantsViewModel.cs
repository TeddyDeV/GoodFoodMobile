using GoodFoodMobile.Models;
using GoodFoodMobile.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoodFoodMobile.ViewModels
{
    public class RestaurantsViewModel : BaseViewModel
    {
        private Restaurant _selectedRestaurant;

        public ObservableCollection<Restaurant> Restaurants { get; }
        public Command LoadRestaurantsCommand { get; }
        public Command AddRestaurantCommand { get; }
        public Command<Restaurant> RestaurantTapped { get; }

        public RestaurantsViewModel()
        {
            Title = "Restaurants";
            Restaurants = new ObservableCollection<Restaurant>();
            LoadRestaurantsCommand = new Command(async () => await ExecuteLoadRestaurantsCommand());

            RestaurantTapped = new Command<Restaurant>(OnRestaurantSelected);

            AddRestaurantCommand = new Command(OnAddRestaurant);
        }

        async Task ExecuteLoadRestaurantsCommand()
        {
            IsBusy = true;

            try
            {
                Restaurants.Clear();
                var restaurants = await restaurantDataStore.GetRestaurantsAsync(true);
                foreach (var restaurant in restaurants)
                {
                    Restaurants.Add(restaurant);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedRestaurant = null;
        }

        public Restaurant SelectedRestaurant
        {
            get => _selectedRestaurant; 
            set
            {
                SetProperty(ref _selectedRestaurant, value);
                OnRestaurantSelected(value);
            }
        }

        private async void OnAddRestaurant(object obj)
        {
            //await Shell.Current.GoToAsync(nameof(NewRestaurantPage));
        }

        async void OnRestaurantSelected(Restaurant restaurant)
        {
            if (restaurant == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}