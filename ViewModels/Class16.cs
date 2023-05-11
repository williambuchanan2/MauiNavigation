using CommunityToolkit.Mvvm.Input;
using MauiApp3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class Class16: BaseViewModel
    {
        [RelayCommand]
        private async void NextButtonPressed()
        {
            try
            {
                NavigationUtil.Navigate<TabH>();
                //ShellItem shellItem = (ShellItem)Shell.Current.FindByName("TabHShellItem");
                //Shell.Current.CurrentItem = shellItem;

                // AppShell.SwitchToLoginShellItem();
                //await Shell.Current.GoToAsync("//TabH");
            }
            catch (Exception ex) {
                throw;
            }


            //AppShell.SwitchToLoginShellItem();
        }

    }
}
