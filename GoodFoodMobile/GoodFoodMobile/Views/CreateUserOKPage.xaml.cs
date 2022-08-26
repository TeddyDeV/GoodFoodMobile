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
	public partial class CreateUserOkPage : ContentPage
	{
        CreateUserOkViewModel _viewModel = new CreateUserOkViewModel();
        public CreateUserOkPage()
		{
			InitializeComponent ();

            this.BindingContext = _viewModel = new CreateUserOkViewModel();
            //_viewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Erreur", "Identifiants Inconnus", "OK");
        }
	}
}