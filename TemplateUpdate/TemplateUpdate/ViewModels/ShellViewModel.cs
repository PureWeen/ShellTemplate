using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewApp.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public Command LogoutCommand { get; }
        public ShellViewModel()
        {
            LogoutCommand = new Command(OnLogout);
        }

        private async void OnLogout(object obj)
        {
            await Shell.Current.GoToAsync("//Login");
        }
    }
}
