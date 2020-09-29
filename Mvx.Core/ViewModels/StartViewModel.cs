using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Presenters;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvx.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigation;

        public StartViewModel(IMvxNavigationService navigation)
        {
            _navigation = navigation;
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
            await _navigation.Navigate<FirstViewModel>();
        }
        private async void ShowSecondView()
        {
            await _navigation.Navigate<SecondViewModel>();
        }
    }
}
