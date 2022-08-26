using GoodFoodMobile.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodFoodMobile.Views
{
    public partial class HomePage : ContentPage
    {

        RestaurantsViewModel _viewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RestaurantsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}