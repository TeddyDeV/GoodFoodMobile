using GoodFoodMobile.Models;
using GoodFoodMobile.Services;
using GoodFoodMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoodFoodMobile.ViewModels
{
    public class AddUserViewModel : INotifyPropertyChanged
    {
        public Command AddUserCommand { get; }
        public Command LoginPageCommand { get; }

        public Action DisplayInvalidLoginPrompt;
        public Action DisplayInvalidPasswordPrompt;

        public event PropertyChangedEventHandler  PropertyChanged = delegate { };

        #region Email / Password
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        } 
        #endregion

        public AddUserViewModel()
        {
            AddUserCommand = new Command(AddUser);
            LoginPageCommand = new Command(LoginPageReturn);
        }

        private async void AddUser(object obj)
        {
            
        }
        private async void LoginPageReturn(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
