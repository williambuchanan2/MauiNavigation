﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Views;

namespace MauiApp3.ViewModels
{
    public partial class TabHvm : BaseViewModel
    {
        [RelayCommand]
        private void NextButtonPressed()
        {
           // NavigationUtil.Navigate<NewPage8>();
            AppShell.SwitchToMainShellItem();
            //NavigationUtil.Navigate<NewPage4>();
        }

    }
}
