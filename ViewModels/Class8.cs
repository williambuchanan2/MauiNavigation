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
    public partial class Class8 : BaseViewModel
    {
        [ObservableProperty]
        public bool _loading;

        [RelayCommand]
        private void NextButtonPressed()
        {
            NavigationUtil.Navigate<NewPage9>();
        }

        [RelayCommand]
        private void CreateAccountPressed()
        {
            Loading = true;

            try
            {
                Thread.Sleep(5000);
            }
            finally
            {
                Loading = false;
            }


        }


    }
}
