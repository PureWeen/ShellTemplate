using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TemplateUpdate.Models;
using Xamarin.Forms;

namespace TemplateUpdate.ViewModels
{
    public class NewItemPageViewModel : BaseViewModel
    {
        private string _text;
        private string _description;

        public NewItemPageViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged += 
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(_text)
                && !String.IsNullOrWhiteSpace(_description);
        }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description
            };

            MessagingCenter.Send(this, "AddItem", newItem);
            await Shell.Current.GoToAsync("..");
        }
    }
}
