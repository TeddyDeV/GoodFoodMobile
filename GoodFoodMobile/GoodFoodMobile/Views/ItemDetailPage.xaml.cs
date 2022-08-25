using GoodFoodMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GoodFoodMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}