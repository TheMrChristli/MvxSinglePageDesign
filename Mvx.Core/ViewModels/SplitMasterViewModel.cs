using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Mvx.Core.ViewModels
{
    public class SplitMasterViewModel : MvxNavigationViewModel
    {
        public SplitMasterViewModel(IMvxNavigationService nav, IMvxLogProvider log)
            : base(log, nav)
        {
            OpenDetailCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SplitDetailViewModel>());

            OpenDetailNavCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SplitDetailNavViewModel>());
        }

        public string PaneText => "Text for the Master Pane";

        public IMvxAsyncCommand OpenDetailCommand { get; private set; }

        public IMvxAsyncCommand OpenDetailNavCommand { get; private set; }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
        }
    }
}