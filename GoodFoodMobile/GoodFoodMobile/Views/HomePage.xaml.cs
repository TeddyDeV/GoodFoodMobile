using GoodFoodMobile.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodFoodMobile.Views
{
    public partial class HomePage : ContentPage
    {

        ItemsViewModel _viewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}