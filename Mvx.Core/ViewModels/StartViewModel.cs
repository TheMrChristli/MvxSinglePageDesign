using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxViewModel<MvxViewModel>
    {
        public StartViewModel(IMvxNavigationService nav)
        {
            ShowFirstViewCommand = new MvxAsyncCommand(async () => await nav.Navigate<StartViewModel, MvxViewModel>(new FirstViewModel()));
            ShowSecondViewCommand = new MvxAsyncCommand(async () => await nav.Navigate<StartViewModel, MvxViewModel>(new SecondViewModel()));
            ShowModalViewCommand = new MvxAsyncCommand(async () => await nav.Navigate<ModalViewModel>());
        }

        public MvxAsyncCommand ShowFirstViewCommand { get; private set; }

        public MvxAsyncCommand ShowSecondViewCommand { get; private set; }

        public MvxAsyncCommand ShowModalViewCommand { get; private set; }

        private MvxViewModel _selectedViewModel;
        public MvxViewModel SelectedModel
        {
            get { return _selectedViewModel; }
            set { SetProperty(ref _selectedViewModel, value); }
        }

        public override void Prepare(MvxViewModel parameter)
        {
            SelectedModel = parameter;
        }
    }
}
