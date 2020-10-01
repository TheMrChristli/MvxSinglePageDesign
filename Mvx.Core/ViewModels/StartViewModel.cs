using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Windows.Input;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxNavigationViewModel
    {
        public StartViewModel(IMvxLogProvider logger, IMvxNavigationService navigation)
            : base(logger, navigation)
        {

        }

        private ICommand _showFirstViewCommand;
        public ICommand ShowFirstViewCommand
        {
            get
            {
                _showFirstViewCommand = _showFirstViewCommand ?? new MvxCommand(ShowFirstView);
                return _showFirstViewCommand;
            }
        }

        private ICommand _showSecondViewCommand;

        public ICommand ShowSecondViewCommand
        {
            get
            {
                _showSecondViewCommand = _showSecondViewCommand ?? new MvxCommand(ShowSecondView);
                return _showSecondViewCommand;
            }
        }

        private async void ShowFirstView()
        {
            await NavigationService.Navigate<FirstViewModel>();
        }
        private async void ShowSecondView()
        {
            await NavigationService.Navigate<SecondViewModel>();
        }
    }
}
