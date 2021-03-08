using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        public StartViewModel()
        {
            //ShowFirstViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<FirstViewModel>());
            //ShowSecondViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SecondViewModel>());
        }

        public MvxAsyncCommand ShowFirstViewCommand { get; private set; }

        public MvxAsyncCommand ShowSecondViewCommand { get; private set; }

        private MvxViewModel _selectedViewModel;

        public MvxViewModel SelectedModel
        {
            get { return _selectedViewModel; }
            set { SetProperty(ref _selectedViewModel, value); }
        }

    }
}
