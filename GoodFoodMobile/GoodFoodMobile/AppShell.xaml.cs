using GoodFoodMobile.ViewModels;
using GoodFoodMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GoodFoodMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddUserPage), typeof(AddUserPage));
        }

    }
}
