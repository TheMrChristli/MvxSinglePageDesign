using MvvmCross.Platforms.Uap.Presenters.Attributes;
using MvvmCross.Platforms.Uap.Views;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Mvx.UWP.Views
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    [MvxRegionPresentation("ActiveItem")]
    public sealed partial class SecondView : MvxWindowsPage
    {
        public SecondView()
        {
            this.InitializeComponent();
        }
    }
}
