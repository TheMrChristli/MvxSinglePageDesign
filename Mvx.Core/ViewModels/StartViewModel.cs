using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        public StartViewModel(IMvxNavigationService nav)
        {
            ShowFirstViewCommand = new MvxCommand(() => SelectedModel = new FirstViewModel());
            ShowSecondViewCommand = new MvxCommand(() => SelectedModel = new SecondViewModel());
            ShowModalViewCommand = new MvxAsyncCommand(async () => await nav.Navigate<ModalViewModel>());
            //ShowFirstViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<FirstViewModel>());
            //ShowSecondViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SecondViewModel>());
        }

        public MvxCommand ShowFirstViewCommand { get; private set; }

        public MvxCommand ShowSecondViewCommand { get; private set; }

        public MvxAsyncCommand ShowModalViewCommand { get; private set; }

        private MvxViewModel _selectedViewModel;

        public MvxViewModel SelectedModel
        {
            get { return _selectedViewModel; }
            set { SetProperty(ref _selectedViewModel, value); }
        }

    }
}
