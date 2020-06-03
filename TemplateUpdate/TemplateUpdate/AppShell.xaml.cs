using System;
using System.Collections.Generic;
using NewApp.ViewModels;
using NewApp.Views;
using Xamarin.Forms;

namespace NewApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            this.BindingContext = new ShellViewModel();
        }
    }
}
