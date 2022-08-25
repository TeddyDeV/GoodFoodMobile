using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GoodFoodMobile.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Accueil";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}