using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mvx.Core.ViewModels
{
    public class TabsRootViewModel : MvxNavigationViewModel
    {
        public TabsRootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowInitialViewModelsCommand = new MvxAsyncCommand(ShowInitialViewModels);
            ShowTabsRootBCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<TabsRootBViewModel>());
        }

        public IMvxAsyncCommand ShowInitialViewModelsCommand { get; private set; }

        public IMvxAsyncCommand ShowTabsRootBCommand { get; private set; }

        private async Task ShowInitialViewModels()
        {
            var tasks = new List<Task>();
            tasks.Add(NavigationService.Navigate<FirstViewModel>());
            tasks.Add(NavigationService.Navigate<SecondViewModel>());
            await Task.WhenAll(tasks);
        }

        private int _itemIndex;

        public int ItemIndex
        {
            get { return _itemIndex; }
            set
            {
                if (_itemIndex == value) return;
                _itemIndex = value;
                Log.Trace("Tab item changed to {0}", _itemIndex.ToString());
                RaisePropertyChanged(() => ItemIndex);
            }
        }
    }
}