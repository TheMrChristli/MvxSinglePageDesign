using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class SplitRootViewModel : MvxNavigationViewModel
    {
        public SplitRootViewModel(IMvxNavigationService nav, IMvxLogProvider log)
            : base(log, nav)
        {
            ShowInitialMenuCommand = new MvxAsyncCommand(ShowInitialViewModel);
            ShowDetailCommand = new MvxAsyncCommand(ShowDetailViewModel);
        }

        public IMvxAsyncCommand ShowInitialMenuCommand { get; private set; }

        public IMvxAsyncCommand ShowDetailCommand { get; private set; }

        public override void ViewAppeared()
        {
            MvxNotifyTask.Create(async () => {
                await ShowInitialViewModel();
                await ShowDetailViewModel();
            });
        }

        private async Task ShowInitialViewModel()
        {
            await NavigationService.Navigate<SplitMasterViewModel>();
        }

        private async Task ShowDetailViewModel()
        {
            await NavigationService.Navigate<SplitDetailViewModel>();
        }
    }
}
