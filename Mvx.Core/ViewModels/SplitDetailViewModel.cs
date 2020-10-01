﻿using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Mvx.Core.ViewModels
{
    public class SplitDetailViewModel : MvxNavigationViewModel
    {
        public SplitDetailViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowChildCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SplitDetailNavViewModel>());
            ShowTabsCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<TabsRootBViewModel>());
            ShowTabbedChildCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<TabsRootViewModel>());
        }

        public IMvxAsyncCommand ShowChildCommand { get; private set; }
        public IMvxAsyncCommand ShowTabsCommand { get; private set; }
        public IMvxAsyncCommand ShowTabbedChildCommand { get; private set; }

        public string ContentText => "Text for the Content Area";

        public override void ViewAppeared()
        {

            MvxNotifyTask.Create(async () =>
            {
                await NavigationService.Navigate<TabsRootViewModel>();
            });
        }
    }
}