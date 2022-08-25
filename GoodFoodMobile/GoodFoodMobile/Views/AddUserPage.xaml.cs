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
        }
	}
}