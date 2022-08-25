using GoodFoodMobile.Models;
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
    public class LoginViewModel : BaseViewModel
    {
        public List<User> Users = new List<User>();
        public Command LoginCommand { get; }
        public Command LoadUsersCommand { get; }

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

        public LoginViewModel()
        {
            LoginCommand = new Command(OnSubmit);
            Users = userDataStore.GetUsers();
            //LoadUsersCommand = new Command(async () => await ExecuteLoadUsersCommand());
        }
        
        //async Task ExecuteLoadUsersCommand()
        //{
        //    IsBusy = true;

        //    try
        //    {
        //        Users.Clear();
        //        var users = await userDataStore.GetUsersAsync(true);
        //        foreach (var user in users)
        //        {
        //            Users.Add(user);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}

        //public async Task<ObservableCollection<User>> GetUsers()
        //{
        //    var users = new ObservableCollection<User>();
        //    users = (ObservableCollection<User>) await userDataStore.GetUsersAsync(true);
            
        //    return users;
        //}


        private async void OnSubmit(object obj)
        {
            // on vérifie que les identifiants correpondent à un compte existant
            if (Users.Count(u => u.email == email) != 0)
            {
                // utilisateur existant
                if (Users.Count(u => u.password == password) != 0)
                {
                    // utilisateur + Mot de passe OK
                    // redirection vers la page d'acceuil
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
                else
                {
                    // mot de passe incorrect
                    DisplayInvalidPasswordPrompt();
                    
                }
            }
            else
            {
                // utilisateur inconnu
                DisplayInvalidLoginPrompt();
            }

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            
            

        }
    }
}
