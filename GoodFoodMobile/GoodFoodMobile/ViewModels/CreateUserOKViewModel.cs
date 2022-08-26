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
    public class CreateUserOkViewModel 
    {
        public Command LoginPageCommand { get; }


        public CreateUserOkViewModel()
        {
            LoginPageCommand = new Command(LoginPageReturn);
        }

        private async void LoginPageReturn(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
