using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvx.Core.ViewModels
{
    public class ModalViewModel : MvxViewModel
    {
        public ModalViewModel(IMvxNavigationService nav)
        {
            YesCommand = new MvxAsyncCommand(async () => await nav.Close(this));
            NoCommand = new MvxAsyncCommand(async () => await nav.Close(this));
            CancelCommand = new MvxAsyncCommand(async () => await nav.Close(this));
        }

        public MvxAsyncCommand YesCommand { get; private set; }
        public MvxAsyncCommand NoCommand { get; private set; }
        public MvxAsyncCommand CancelCommand { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

    }
}
