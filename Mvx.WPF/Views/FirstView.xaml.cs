using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;

namespace Mvx.WPF.Views
{
    /// <summary>
    /// Interaktionslogik für FirstView.xaml
    /// </summary>
    [MvxContentPresentation]
    public partial class FirstView : MvxWpfView
    {
        public FirstView()
        {
            InitializeComponent();
        }
    }
}
