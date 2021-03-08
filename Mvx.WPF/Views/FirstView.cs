using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using Mvx.Core.ViewModels;

namespace Mvx.WPF.Views
{
    /// <summary>
    /// Interaktionslogik für FirstView.xaml
    /// </summary>
    [MvxContentPresentation(WindowIdentifier = nameof(MainWindow), StackNavigation = false)]
    public partial class FirstView : MvxWpfView<FirstViewModel>
    {
        public FirstView()
        {
            InitializeComponent();
        }
    }
}
