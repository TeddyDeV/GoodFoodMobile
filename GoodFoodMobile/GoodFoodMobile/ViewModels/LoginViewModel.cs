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
    public class LoginViewModel : INotifyPropertyChanged
    {
        public List<User> Users;
        public Command LoginCommand { get; }
        public Command AddUserCommand { get; }
        public Command LoadUsersCommand { get; }

        UsersDataStore userDataStore = new UsersDataStore();

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
            AddUserCommand = new Command(AddUser);
            
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
            Users = userDataStore.GetUsers();
            // on vérifie que les identifiants correpondent à un compte existant
            if (Users.Count(u=> u.email == email && u.password == password) != 0)
            {
                    await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
            {
                DisplayInvalidLoginPrompt();
            }
        }

        private async void AddUser(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AddUserPage)}");
        }
    }
}
