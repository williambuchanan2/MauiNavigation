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
    public partial class Class2: BaseViewModel
    {
        [ObservableProperty]
        public string _testText;


        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<NewPage3>();
        }

    }
}
