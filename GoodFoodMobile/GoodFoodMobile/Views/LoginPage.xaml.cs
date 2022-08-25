using GoodFoodMobile.Models;
using GoodFoodMobile.Services;
using GoodFoodMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodFoodMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        LoginViewModel _viewModel = new LoginViewModel();
        List<User> users;       
            ObservableCollection<User> ListUsers = new ObservableCollection<User>();
        public LoginPage()
        {
            InitializeComponent();

            this.BindingContext = _viewModel = new LoginViewModel();
            _viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Erreur", "Email Inconnu", "OK");
            _viewModel.DisplayInvalidPasswordPrompt += () => DisplayAlert("Erreur", "Mot de passe incorrect", "OK");

            //users = new List<User>()
            //{
            //    new User { id = Guid.NewGuid().ToString(), lastName = "Devin", firstName = "Teddy", email = "teddy.devin@viacesi.fr", password = "123", address = "70 rue entre deux landes" , postalCode = "76220", city ="La Feuillie" },
            //    new User { id = Guid.NewGuid().ToString(), lastName = "John", firstName = "Doe", email = "john.doe@viacesi.fr", password = "123", address = "2 rue des portiers" , postalCode = "76000", city ="Rouen" }
            //};


            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                _viewModel.LoginCommand.Execute(null);
               // GetAllUsers();
            };
                       
        }


        //public async void GetAllUsers()
        //{
        //    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        //}

        

    }
}