using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync("//Browse");
        }
    }
}
