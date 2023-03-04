﻿using CommunityToolkit.Mvvm.Input;
using MauiApp3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class Class1: BaseViewModel
    {

        [RelayCommand]
        private void NextButtonPressed()
        {
            AppShell.SwitchToLoginShellItem();
            NavigationUtil.Navigate<NewPage2>();
        }

        [RelayCommand]
        private void Scenario2ButtonPressed()
        {
             NavigationUtil.Navigate<NewPage2>();
        }

    }
}
