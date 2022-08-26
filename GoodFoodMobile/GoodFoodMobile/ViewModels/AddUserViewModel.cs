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

        UsersDataStore userDataStore = new UsersDataStore();

        public Command AddUserCommand { get; }
        public Command LoginPageCommand { get; }

        public Action DisplayInvalidLoginPrompt;
        public Action DisplayInvalidPasswordPrompt;

        public event PropertyChangedEventHandler  PropertyChanged = delegate { };

        #region Informations utilisateur

        #region FirstName
        private string firstName;
        public string FistName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        #endregion

        #region LastName
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
            }
        }
        #endregion

        #region Email
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
        #endregion

        #region Password
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

        #region Address
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }
        #endregion

        #region PostalCode
        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                postalCode = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PostalCode"));
            }
        }
        #endregion

        #region City
        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                PropertyChanged(this, new PropertyChangedEventArgs("City"));
            }
        }
        #endregion

        #region PhoneNumber
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        } 
        #endregion

        #endregion

        public AddUserViewModel()
        {
            AddUserCommand = new Command(AddUser);
            LoginPageCommand = new Command(LoginPageReturn);
        }

        private async void AddUser(object obj)
        {
            User user = new User { firstName = firstName, lastName = lastName, email = email, password = password , address = address , postalCode = postalCode , city = city , phoneNumber = phoneNumber };
            
            userDataStore.AddUser(user);
            await Shell.Current.GoToAsync($"//{nameof(CreateUserOkPage)}");
        }
        private async void LoginPageReturn(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
