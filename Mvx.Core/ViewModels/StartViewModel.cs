using MvvmCross.Commands;
using MvvmCross.Logging;
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
    public class StartViewModel : MvxNavigationViewModel
    {
        private readonly IMvxLogProvider _logger;
        private readonly IMvxNavigationService _navigation;

        public StartViewModel(IMvxLogProvider logger, IMvxNavigationService navigation)
            : base(logger, navigation)
        {
            _logger = logger;
            _navigation = navigation;

            ShowInitialViewModelsCommand = new MvxAsyncCommand(ShowInitialViewModels);
        }

        public IMvxAsyncCommand ShowInitialViewModelsCommand { get; private set; }

        private async Task ShowInitialViewModels()
        {
            var tasks = new List<Task>();
            tasks.Add(NavigationService.Navigate<FirstViewModel>());
            tasks.Add(NavigationService.Navigate<SecondViewModel>());
            await Task.WhenAll(tasks);
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
