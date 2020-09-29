using MvvmCross.Core;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Uap.Views;
using Mvx.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Mvx.UWP.Views
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainView : MvxWindowsPage
    {
        private readonly MainViewModel _mainViewModel;

        public MainView(MainViewModel mainViewModel)
        {
            this.InitializeComponent();
     
            _mainViewModel = mainViewModel;
        }

        private void ItemFrame_Holding(object sender, HoldingRoutedEventArgs e)
        {
            ItemFrame.SetValue(null, _mainViewModel.newViewModel);
        }
    }
}
