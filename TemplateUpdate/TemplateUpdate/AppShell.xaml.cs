using System;
using System.Collections.Generic;
using TemplateUpdate.ViewModels;
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
            this.BindingContext = new ShellViewModel();
        }
    }
}
