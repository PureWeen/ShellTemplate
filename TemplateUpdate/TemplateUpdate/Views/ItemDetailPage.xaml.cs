using System.ComponentModel;
using Xamarin.Forms;
using NewApp.ViewModels;

namespace NewApp.Views
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