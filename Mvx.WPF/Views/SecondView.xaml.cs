using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;

namespace Mvx.WPF.Views
{
    /// <summary>
    /// Interaktionslogik für SecondView.xaml
    /// </summary>
    [MvxContentPresentation]
    public partial class SecondView : MvxWpfView
    {
        public SecondView()
        {
            InitializeComponent();
        }
    }
}
