using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxNavigationViewModel
    {
        public StartViewModel(IMvxLogProvider logger, IMvxNavigationService navigation)
            : base(logger, navigation)
        {
            ShowFirstViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<FirstViewModel>());
            ShowSecondViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SecondViewModel>());
        }

        public MvxAsyncCommand ShowFirstViewCommand { get; private set; }

        public MvxAsyncCommand ShowSecondViewCommand { get; private set; }
    }
}
