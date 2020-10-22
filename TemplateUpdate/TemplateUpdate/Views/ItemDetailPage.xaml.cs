using NewApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

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