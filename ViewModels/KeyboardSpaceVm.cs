using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp3.ViewModels
{
    public partial class KeyboardSpaceVm : BaseViewModel
    {
        [ObservableProperty]
        public string _testText;

        public Task ShowAlertAsync(string title, string message, string cancel = "OK")
        {
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

    [RelayCommand]
        private void NextButtonPressed()
        {
            Application.Current.MainPage.Dispatcher.Dispatch(async () => await ShowAlertAsync("Boo", "Pressed", "OK"));
        }

    }
}
