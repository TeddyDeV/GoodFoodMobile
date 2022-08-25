using GoodFoodMobile.Services;
using GoodFoodMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodFoodMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
