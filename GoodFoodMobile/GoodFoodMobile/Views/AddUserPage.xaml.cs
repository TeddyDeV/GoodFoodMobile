using GoodFoodMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodFoodMobile.Views
{
	public partial class AddUserPage : ContentPage
	{
        AddUserViewModel _viewModel = new AddUserViewModel();
        public AddUserPage ()
		{
			InitializeComponent ();

            this.BindingContext = _viewModel = new AddUserViewModel();
            //_viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Erreur", "Identifiants Inconnus", "OK");

            #region Champs completé
            LastName.Completed += (object sender, EventArgs e) =>
            {
                FirstName.Focus();
            };

            FirstName.Completed += (object sender, EventArgs e) =>
            {
                Email.Focus();
            };

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                Address.Focus();
            };

            Address.Completed += (object sender, EventArgs e) =>
            {
                PostalCode.Focus();
            };

            PostalCode.Completed += (object sender, EventArgs e) =>
            {
                City.Focus();
            };

            City.Completed += (object sender, EventArgs e) =>
            {
                PhoneNumber.Focus();
            };

            PhoneNumber.Completed += (object sender, EventArgs e) =>
            {
                _viewModel.AddUserCommand.Execute (this);
            }; 
            #endregion


        }
	}
}