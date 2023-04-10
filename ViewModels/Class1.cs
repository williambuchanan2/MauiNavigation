using CommunityToolkit.Mvvm.Input;
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

        [RelayCommand]
        private void ImageErrorButtonPressed()
        {
            NavigationUtil.Navigate<ImageError>();
        }

        [RelayCommand]
        private void ScrollViewProblemButtonPressed()
        {
            NavigationUtil.Navigate<ScrollViewIssue>();
        }

        [RelayCommand]
        private void ImageInListButtonPressed()
        {
            NavigationUtil.Navigate<NewPage7>();
        }

        [RelayCommand]
        private void AbsoluteLayoutButtonPressed()
        {
            NavigationUtil.Navigate<NewPage8>();
        }

        [RelayCommand]
        private void KeyboardProblemButtonPressed()
        {
            NavigationUtil.Navigate<NewPage9>();
        }

        [RelayCommand]
        private void NavToProblemButtonPressed()
        {
            AppShell.SwitchToMainShellItem();
        }

        [RelayCommand]
        private void ImageProblem2ButtonPressed()
        {
            NavigationUtil.Navigate<ImageError2>();
        }

        [RelayCommand]
        private void ImageProblem3ButtonPressed()
        {
            NavigationUtil.Navigate<ImageError3>();
        }



    }
}
