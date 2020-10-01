using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace Mvx.UWP
{
    /// <summary>
    /// Stellt das anwendungsspezifische Verhalten bereit, um die Standardanwendungsklasse zu ergänzen.
    /// </summary>
    sealed partial class App
    {
        /// <summary>
        /// Initialisiert das Singletonanwendungsobjekt. Dies ist die erste Zeile von erstelltem Code
        /// und daher das logische Äquivalent von main() bzw. WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class DemoApp : MvxApplication<MvxWindowsSetup<Core.App>, Core.App>
    {

    }
}
