using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvx.Core.ViewModels
{
    public class SecondViewModel : MvxNavigationViewModel
    {
        // https://github.com/MvvmCross/MvvmCross/tree/develop/Projects/Playground/Playground.Core/ViewModels/Navigation
        public SecondViewModel(IMvxNavigationService navigationService, IMvxLogProvider log) : base(log, navigationService)
        {
            ShowRootViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<StartViewModel>());

            CloseViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Close(this));
        }
        public IMvxAsyncCommand ShowRootViewModelCommand { get; private set; }

        public IMvxAsyncCommand CloseViewModelCommand { get; private set; }
    }
}
