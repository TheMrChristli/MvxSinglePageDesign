using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Mvx.Core.ViewModels
{
    public class SecondViewModel : MvxNavigationViewModel
    {
        // https://github.com/MvvmCross/MvvmCross/tree/develop/Projects/Playground/Playground.Core/ViewModels/Navigation
        public SecondViewModel(IMvxNavigationService navigationService, IMvxLogProvider log) : base(log, navigationService)
        {
            SetMessageCommand = new MvxCommand(() => Message = "Hello");
        }

        public MvxCommand SetMessageCommand { get; private set; }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
