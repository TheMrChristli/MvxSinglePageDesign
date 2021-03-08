using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Mvx.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {

        public FirstViewModel()
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
