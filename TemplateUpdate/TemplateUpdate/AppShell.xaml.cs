using System;
using System.Collections.Generic;
using TemplateUpdate.Views;
using Xamarin.Forms;

namespace TemplateUpdate
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            CurrentItem = login;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await GoToAsync("//Login");
        }
    }
}
