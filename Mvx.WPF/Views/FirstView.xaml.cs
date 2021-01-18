using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace Mvx.WPF.Views
{
    /// <summary>
    /// Interaktionslogik für FirstView.xaml
    /// </summary>
    public partial class FirstView : MvxWpfView
    {
        public FirstView()
        {
            InitializeComponent();
        }

        public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
        {
            return new MvxContentPresentationAttribute
            {
                WindowIdentifier = $"{nameof(FirstView)}",
                StackNavigation = false
            };
        }
    }
}
