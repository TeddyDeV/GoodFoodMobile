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
        public LoginPage()
        {
            InitializeComponent();

            this.BindingContext = _viewModel = new LoginViewModel();
            _viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Erreur", "Identifiants Inconnus", "OK");
            //_viewModel.DisplayInvalidPasswordPrompt += () => DisplayAlert("Erreur", "Mot de passe incorrect", "OK");



            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                _viewModel.LoginCommand.Execute(null);
            };
                       
        }



        

    }
}